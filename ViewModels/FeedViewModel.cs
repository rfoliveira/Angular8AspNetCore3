using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular8AspNetCore3.ViewModels
{
    public class FeedViewModel
    {
        public string Link { get; set; }
        public string Title { get; set; }
        public string FeedType { get; set; }
        public string Author { get; set; }
        public string Content { get; set; }
        public DateTime PubDate { get; set; }
        public string PublishDate { get; set; }

        public FeedViewModel()
        {
            Link = "";
            Title = "";
            FeedType = "";
            Author = "";
            Content = "";
            PubDate = DateTime.Today;
            PublishDate = DateTime.Today.ToString("dd-MMM-yyyy");
        }

    }
}
