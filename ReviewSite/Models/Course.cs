using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ReviewSite.Models
{
    public class Course
    {
        public string Title { get; set; }

        public int CourseId { get; set; }

        public string ImageURL { get; set; }

        public string Overview { get; set; }

        public string Summary { get; set; }

        public string AvgRating { get; set; }

        public string StartDate { get; set; }

        public string Duration { get; set; }

        public virtual IEnumerable<UserReview> UserReviews { get; set; }

        public int CategoryId { get; set; }

        public virtual Category Category { get; set; }
        
        [NotMapped]
        public ICollection<string> TagList { get; set; }

        public Course()
        {

        }
        
        // For when a real review is made
        public Course(string title, int id, string imageURL, string overview, string summary, List<string> taglist)
        {
            Title = title;
            CourseId = id;
            ImageURL = imageURL;
            Overview = overview;
            Summary = summary;
            TagList = taglist;
            UserReviews = new List<UserReview>();
        }

        // For when testing with hard coded user reviews
        public Course(string title, int id, string imageURL, string overview, string summary, List<string> taglist, List<UserReview> userReview)
        {
            Title = title;
            CourseId = id;
            ImageURL = imageURL;
            Overview = overview;
            Summary = summary;
            UserReviews = userReview;
            TagList = taglist;
        }

        public decimal AverageRating()
        {
            decimal totalRating = 0M;
            foreach (UserReview review in UserReviews)
            {
                totalRating += review.Rating;
            }

            decimal avgRating = totalRating / UserReviews.Count();

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
