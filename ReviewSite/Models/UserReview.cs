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

        public int SolidStars()
        {

            int solidStars = Convert.ToInt32(Math.Truncate(Rating));

            return solidStars;
        }

        public int HalfStars()
        {
            int halfStars = 0;

            decimal dec = Rating % 1;

            if (dec >= 0.3M && dec <= 0.8M)
            {
                halfStars = 1;
            }

            return halfStars;
        }

        public int EmptyStars()
        {
            int solidStars = SolidStars();
            int halfStars = HalfStars();

            int emptyStars = 5 - (solidStars + halfStars);

            return emptyStars;
        }
    }
}
