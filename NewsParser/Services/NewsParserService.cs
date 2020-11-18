using System;
using System.Collections.Generic;
using System.Configuration;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using HtmlAgilityPack;
using Microsoft.Extensions.Configuration;
using NewsParser.Models;

namespace NewsParser.Services
{
    public class NewsParserService:INewsParserServices
    {

        private int NewsId = 1; //Для добавления данных при миграции так как требуется идентифицировать 
        private static readonly string Url = "https://www.nur.kz/";
        public IConfiguration Configuration { get; }
        
        private IList<News> parsedNews = new List<News>();
        
        // К сожалению пришлось ввести такое жесткоё разделение по категориям, потому что новости располагаются по разным адресам
        private static readonly string WorldThemeSubUrl = "/world";
        private static readonly string ShowBizThemeSubUrl = "/showbiz";
        private static readonly string SocietyThemeSubUrl = "/society";
        
        public NewsParserService(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        public IList<News> GetNewsFromWebSite()
        {
            Task.WhenAll(
                GetNewsFromSubUrl(WorldThemeSubUrl),
                GetNewsFromSubUrl(ShowBizThemeSubUrl),
                GetNewsFromSubUrl(SocietyThemeSubUrl)
                );
            
            return parsedNews;
        }

        private async Task GetNewsFromSubUrl(string subUrl)
        {
            var page = new HtmlWeb();
            var doc = page.Load(Url+subUrl);
            
            //статьи на странице с рубриками
            var articles = doc.DocumentNode
                .SelectNodes(Configuration.GetValue<string>("Parser:ArticleXPath"))
                .Take(10);
            
            //ссылки на новости для получения текста новостей и времени
            var hrefs = doc.DocumentNode
                .SelectNodes(Configuration.GetValue<string>("Parser:HrefXPath"))
                .Take(10)
                .Select(x=>x.Attributes["href"].Value);
            
            //все тексты и время новостей
            var all_text = GetNewsSection(hrefs,Configuration.GetValue<string>("Parser:TextXPath"));
            var all_times = GetNewsSection(hrefs,Configuration.GetValue<string>("Parser:TimeXPath"));
            
            var section_index = 0; // индекс для прохождения по списку

            foreach (var article in articles)
            {
                var news_data = article.InnerText.Trim().Replace("\n", "`").Split("`");// разделение все статьи по секциям
                var dateFromPost = news_data[2].Trim(); //секция с датой
                var themeFromPost = news_data[0];//секция с оглавлением
                    try 
                    {
                        var news = new News(all_text[section_index].Replace("&quot;","'").Replace("&amp;","&"), themeFromPost); //Замена на одинарные кавычки
                        
                        news.Id = NewsId; // для миграции, метод HasData требует присовения Id несмотря на автоинкремент 
                        
                        //Посты на nur.kz хранят либо время если пост сегодняшний, либо дату. Если время то там двоеточие появляется
                        if (dateFromPost.Contains(":")) 
                            news.NewsDate = DateTime.ParseExact(dateFromPost, "HH:mm",
                                CultureInfo.InvariantCulture);
                        else
                        {   
                            //выбор времени из поста для дальнейшего инкремента к дате
                            var time = all_times[section_index].Split(",")[1].Trim(); //выбор именно времени  без учёта слова "Сегодня"
                            
                            var timeSpan = TimeSpan.Parse(time); // Конвертация времени для добавления в текущую дату
                            
                            news.NewsDate = DateTime.ParseExact(dateFromPost, "yyyy-MM-dd", CultureInfo.InvariantCulture)
                                            .Add(timeSpan);
                        }

                        parsedNews.Add(news);
                        section_index++;
                        NewsId++;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
            }
        }

        //Возвращает значение элемента(как правило это текст) по XPath(путь к html элементу) PS: Все пути прописаны в appsettings.json
        private IList<string> GetNewsSection(IEnumerable<string> urls, string xPath)
        {
            var texts = new List<string>();
            foreach (var url in urls)
            {
                var page = new HtmlWeb();
                var doc = page.Load(url);

                var text = doc.DocumentNode
                    .SelectSingleNode(xPath)
                    .InnerText;

                texts.Add(text);
            }

            return texts;
        }
    }
}