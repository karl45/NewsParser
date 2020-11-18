using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NewsParser.Models;
using NewsParser.Services;

namespace NewsParser.DataContext
{
    public class NewsContext:DbContext
    {
        private readonly INewsParserServices _newsParserService;
        public NewsContext(DbContextOptions<NewsContext> options,
            INewsParserServices parserService):base(options)
        { 
            _newsParserService = parserService;
            Database.Migrate();
        }
        
        
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<News>().ToTable("News");
            modelBuilder.Entity<News>().HasData(_newsParserService.GetNewsFromWebSite());
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<News> News { set; get; }
    }
}
