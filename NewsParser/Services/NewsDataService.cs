using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NewsParser.DataContext;
using NewsParser.Models;

namespace NewsParser.Services
{
    public class NewsDataService
    {
        private readonly NewsContext _context;

        public NewsDataService(NewsContext newsContext)
        {
            _context = newsContext;
        }

        public async Task SaveNews(News news)
        {
            try
            {
                _context.Add(news);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        public async Task SaveManyNews(IList<News> news)
        {
            try
            {
                _context.AddRange(news);
                await _context.SaveChangesAsync();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        
        public IList<News> GetAllNews() => _context.News.ToList();

        public IList<string> GetMinAndMaxDate()
        {
            var max = _context.News.Max(x => x.NewsDate);
            var min = _context.News.Min(x => x.NewsDate);
            return new List<string>(){max.Value.ToString("yyyy-MM-ddThh:mm"),min.Value.ToString("yyyy-MM-ddThh:mm")};
        }
        
        public IList<News> GetNewsByDate(DateTime? from, DateTime? to) => 
            _context.News
                .Where(x => x.NewsDate >= from && x.NewsDate <= to)
                .ToList();

        public IList<News> GetNewsByText(string text) => 
            _context.News
                .Where(x => EF.Functions.Like(x.Text, $"%{text}%"))
                .ToList();

        public IEnumerable<KeyValuePair<string,int>> TopTen()
        {
            var allTextsFromPosts = _context.News.Select(x => x.Text).ToList();
            var splittedText = new ConcurrentBag<string[]>(); //Аналог класса List для многопточного рефакторинга. Для раздления текста на слова
            var countWord = new ConcurrentDictionary<string, int>(); //Аналог класса Dictionary для многопточного рефакторинга. Предназначен для хранения слов и количествоих встречаний в новостях
            var maxWordDict = new Dictionary<string, int>();// для отсортированного списка
            
            Parallel.For(0, allTextsFromPosts.Count, text =>
            {
                splittedText.Add(allTextsFromPosts[text]?.Trim().Split(" "));
            });

            var lockObj = new object();//объект для локировки
            
            Parallel.ForEach(splittedText, splitText =>
            {
                Parallel.For(0, splitText.Length, wordIndex =>
                 {
                     lock (lockObj)// Пришлось прибегнуть к локировке так как сумма повторений постоянно менялась
                     {
                         var cleanStr = splitText[wordIndex]
                             .Replace(". ", String.Empty)
                             .Replace(",", String.Empty)
                             .Replace("'", String.Empty)
                             .Replace(":", String.Empty)
                             .Replace("-", String.Empty)
                             .Replace("!", String.Empty); //очистка слова от разных знаков препинания

                         if (!cleanStr.Equals(String.Empty)) // к сожалению такие знаки как " - ", которые после фильтррации стали пустой строкой,  тоже посчитались словом во время сплита, поэтому они тоже убираются
                             if (!countWord.TryAdd(cleanStr, 1)) //инкремент на 1 поменял
                                 countWord[cleanStr] += 1; //происходило дублирование так как подставлялось общее значение через метод Count()
                     }
                 });

            });
            
            //сортировка по количеству совпадений
            var values = countWord
                .Select(x=>new{x.Key,x.Value})
                .OrderByDescending(x=>x.Value)
                .ToList();
            
            //добавление отсортированного словаря в новый словарь
            foreach (var value in values)
                maxWordDict.Add(value.Key,value.Value);
            
            return maxWordDict.Take(10);//Take(10) - выбрать первые 10 элементов
        }
    }
}