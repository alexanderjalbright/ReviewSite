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
            var userOpinionList = new List<string>() { "Its free!", "You get what you pay for and it's free.", "The instructors are racist." };
            var tagList = new List<string>() { "Coding", "AI" };
            underTest = new Review("Machine Learning", 1, "Algorithms", "./images/MachineLearning.jpg", "Learn to use machine learning to your advantage.", "Learn Machine learning.", tagList, userOpinionList);
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
            string expected = "./images/MachineLearning.jpg";

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
    }
}
