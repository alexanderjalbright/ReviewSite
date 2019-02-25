using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class UserReview
    {
        public string UserName { get; private set; }

        public string Comment { get; private set; }

        public decimal Rating { get; private set; }

        public UserReview(string userName, string comment, decimal rating)
        {
            UserName = userName;
            Comment = comment;
            Rating = rating;
        }
    }
}
