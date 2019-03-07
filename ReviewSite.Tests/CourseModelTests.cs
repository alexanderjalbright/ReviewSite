using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class CourseModelTests
    {
        Course underTest;

        public CourseModelTests()
        {
            underTest = new Course
                (
                    "Machine Learning",
                    1,
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
        public void Course_Has_Title()
        {
            string expected = "Machine Learning";

            var result = underTest.Title;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Has_Id()
        {
            int expected = 1;

            var result = underTest.CourseId;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Has_Image_URL()
        {
            string expected = "/Images/machinelearning.jpg";

            var result = underTest.ImageURL;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Has_Overview()
        {
            string expected = "Learn to use machine learning to your advantage.";

            var result = underTest.Overview;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Has_Summary()
        {
            string expected = "Learn Machine learning.";

            var result = underTest.Summary;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void Course_Has_Tags()
        {
            var result = underTest.TagList;

            Assert.NotEmpty(result);
        }

        [Fact]
        public void Course_Has_Average_Rating()
        {
            var result = underTest.AverageRating();

            decimal expected = 3.8M;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Calculates_Solid_Stars()
        {
            var result = underTest.SolidStars();
            int expected = 4;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Calculates_Half_Stars()
        {
            var result = underTest.HalfStars();
            int expected = 0;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Course_Calculates_Empty_Stars()
        {
            var result = underTest.EmptyStars();
            int expected = 1;

            Assert.Equal(expected, result);
        }
    }
}
