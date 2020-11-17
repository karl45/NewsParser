using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NewsParser.DataContext;
using NewsParser.Models;
using NewsParser.Services;

namespace NewsParser.Controllers
{
    public class NewsController : Controller
    {
        public readonly INewsParserServices _ParserServices;
        public readonly NewsDataService _DataService;
        public NewsController(
            INewsParserServices parserService,
            NewsDataService newsDataService)
        {
            _DataService = newsDataService;
            _ParserServices = parserService;
        }
        // GET
        public IActionResult Index()
        {
            var allNews =  _DataService.GetAllNews();
            var MinAndMaxDate = _DataService.GetMinAndMaxDate();
            ViewData["To"] = MinAndMaxDate[0];
            ViewData["From"] = MinAndMaxDate[1];
            return View(allNews);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IList<News> Posts([FromBody] [Bind("From,To")] DateFromToViewModel dateFromToViewModel) => _DataService.GetNewsByDate(dateFromToViewModel.From, dateFromToViewModel.To);

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IList<News> Search(string text) => _DataService.GetNewsByText(text);

        [HttpGet]
        public IEnumerable<KeyValuePair<string,int>> TopTen() => _DataService.TopTen();
        
    }
}