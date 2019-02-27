using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Review
    {
        public string Title { get; set; }

        public int ReviewId { get; set; }

        public string Category { get; set; }

        public string ImageURL { get; set; }

        public string Overview { get; set; }

        public string Summary { get; set; }

        public string AvgRating { get; set; }

        public virtual IEnumerable<UserReview> UserReview { get; set; }
        
        [NotMapped]
        public ICollection<string> TagList { get; set; }

        public Review()
        {

        }
        
        // For when a real review is made
        public Review(string title, int id, string category, string imageURL, string overview, string summary, List<string> taglist)
        {
            Title = title;
            ReviewId = id;
            Category = category;
            ImageURL = imageURL;
            Overview = overview;
            Summary = summary;
            TagList = taglist;
            UserReview = new List<UserReview>();
        }

        // For when testing with hard coded user reviews
        public Review(string title, int id, string category, string imageURL, string overview, string summary, List<string> taglist, List<UserReview> userReview)
        {
            Title = title;
            ReviewId = id;
            Category = category;
            ImageURL = imageURL;
            Overview = overview;
            Summary = summary;
            UserReview = userReview;
            TagList = taglist;
        }

        public decimal AverageRating()
        {
            decimal totalRating = 0M;
            foreach (UserReview review in UserReview)
            {
                totalRating += review.Rating;
            }

            decimal avgRating = totalRating / UserReview.Count();

            decimal roundedAvgRating = Math.Round(avgRating, 1);

            return roundedAvgRating;
        }

        public int SolidStars()
        {
            decimal avgRating = AverageRating();

            int solidStars = Convert.ToInt32(Math.Truncate(avgRating));

            return solidStars;
        }

        public int HalfStars()
        {
            decimal avgRating = AverageRating();

            int halfStars = 0;

            decimal dec = avgRating % 1;

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
