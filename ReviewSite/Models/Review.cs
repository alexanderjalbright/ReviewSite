using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Review
    {
        public string Title { get; private set; }

        public int Id { get; private set; }

        public string Category { get; private set; }

        public string ImageURL { get; private set; }

        public string Overview { get; private set; }

        public string Summary { get; private set; }

        public List<string> UserOpinionList { get; private set; }

        public List<string> TagList { get; private set; }

        public Review()
        {

        }
        
        // For when a real review is made
        public Review(string title, int id, string category, string imageURL, string overview, string summary, List<string> taglist)
        {
            Title = title;
            Id = id;
            Category = category;
            ImageURL = imageURL;
            Overview = overview;
            Summary = summary;
            TagList = taglist;
            UserOpinionList = new List<string>();
        }

        // For when testing with hard coded user reviews
        public Review(string title, int id, string category, string imageURL, string overview, string summary, List<string> taglist, List<string> userOpinionList)
        {
            Title = title;
            Id = id;
            Category = category;
            ImageURL = imageURL;
            Overview = overview;
            Summary = summary;
            UserOpinionList = userOpinionList;
            TagList = taglist;
        }
    }
}
