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
        private readonly INewsParserServices _parserServices;
        private readonly NewsDataService _dataService;
        public NewsController(
            INewsParserServices parserService,
            NewsDataService newsDataService)
        {
            _dataService = newsDataService;
            _parserServices = parserService;
        }
        // GET
        public IActionResult Index()
        {
            var allNews =  _dataService.GetAllNews();
            var minAndMaxDate = _dataService.GetMinAndMaxDate();
            ViewData["To"] = minAndMaxDate[0];
            ViewData["From"] = minAndMaxDate[1];
            return View(allNews);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IList<News> Posts([FromBody] [Bind("From,To")] DateFromToViewModel dateFromToViewModel) => _dataService.GetNewsByDate(dateFromToViewModel.From, dateFromToViewModel.To);

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IList<News> Search(string text) => _dataService.GetNewsByText(text);

        [HttpGet]
        public IEnumerable<KeyValuePair<string,int>> TopTen() => _dataService.TopTen();
        
    }
}