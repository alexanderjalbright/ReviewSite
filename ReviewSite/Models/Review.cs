﻿using System;
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

        public string Content { get; private set; }

        public string Summary { get; private set; }

        public Review()
        {

        }

        public Review(string title, int id, string category, string imageURL, string content, string summary)
        {
            Title = title;
            Id = id;
            Category = category;
            ImageURL = imageURL;
            Content = content;
            Summary = summary;
        }


    }
}
