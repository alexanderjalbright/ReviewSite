using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewModelTests
    {
        Review underTest;

        public ReviewModelTests()
        {
            underTest = new Review
                (
                    "Machine Learning",
                    1,
                    "Algorithms",
                    "/Images/machinelearning.jpg",
                    "Learn to use machine learning to your advantage.",
                    "Learn Machine learning.",
                    new List<string>() { "Coding", "AI" },
                    new List<UserReview>()
                    {
                        new UserReview("MoocJunkie", "Its free!", 3.3M),
                        new UserReview("SwagYoloFleekDabs", "You get what you pay for and it's free.", 4.1M),
                        new UserReview("xXx_DragonSlayer_xXx", "The instructors are racist.", 3.9M)
                    }
                );
        }

        [Fact]
        public void Review_Has_Title()
        {
            string expected = "Machine Learning";

            var result = underTest.Title;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Id()
        {
            int expected = 1;

            var result = underTest.Id;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Category()
        {
            string expected = "Algorithms";

            var result = underTest.Category;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Image_URL()
        {
            string expected = "/Images/machinelearning.jpg";

            var result = underTest.ImageURL;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Overview()
        {
            string expected = "Learn to use machine learning to your advantage.";

            var result = underTest.Overview;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Summary()
        {
            string expected = "Learn Machine learning.";

            var result = underTest.Summary;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_User_Opinion_List()
        {
            var result = underTest.UserOpinionList;

            Assert.NotEmpty(result);
        }

        [Fact]
        public void Review_Has_Tags()
        {
            var result = underTest.TagList;

            Assert.NotEmpty(result);
        }

        [Fact]
        public void Review_Has_Average_Rating()
        {
            var result = underTest.AverageRating();

            decimal expected = 3.8M;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Calculates_Solid_Stars()
        {
            var result = underTest.SolidStars();
            int expected = 3;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Calculates_Half_Stars()
        {
            var result = underTest.HalfStars();
            int expected = 1;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Calculates_Empty_Stars()
        {
            var result = underTest.EmptyStars();
            int expected = 1;

            Assert.Equal(expected, result);
        }
    }
}
