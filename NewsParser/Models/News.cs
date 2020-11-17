using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NewsParser.Models
{
    public class News
    {
        public News()
        {
        }

        public News(string? text, string? theme)
        {
            Text = text;
            Theme = theme;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { set; get; }
        
        public string? Text { set; get; }
        
        public  string? Theme { set; get; }
        
        public DateTime? NewsDate { set; get; }
    }
}