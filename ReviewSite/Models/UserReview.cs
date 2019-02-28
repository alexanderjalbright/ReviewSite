using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class UserReview
    {
        public int UserReviewId { get; set; }

        public string UserName { get; set; }

        public string Comment { get; set; }

        public decimal Rating { get; set; }

        public int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public UserReview()
        {

        }

        public UserReview(string userName, string comment, decimal rating)
        {
            UserName = userName;
            Comment = comment;
            Rating = rating;
        }
    }
}
