using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class UserReview
    {
        public int UserReviewId { get; set; }

        [Display(Name = "", Prompt = "Username")]
        public string UserName { get; set; }

        [Display(Name = "", Prompt = "Comment")]
        public string Comment { get; set; }

        [Display(Name = "", Prompt = "Rating (0.0-5.0")]
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
            decimal dec = Rating % 1;

            if (dec > 0.7M)
            {
                solidStars += 1;
            }

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
