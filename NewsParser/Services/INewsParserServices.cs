using System.Collections.Generic;
using NewsParser.Models;

namespace NewsParser.Services
{
    public interface INewsParserServices
    {
        IList<News> GetNewsFromWebSite();
    }
}