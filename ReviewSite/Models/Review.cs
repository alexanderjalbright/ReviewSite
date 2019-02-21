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

        public Review()
        {

        }

        public Review(string title)
        {
            Title = title;
        }

        public Review(string title, int id)
        {
            Title = title;
            Id = id;
        }


    }
}
