using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class UserReviewModelTests
    {
        UserReview underTest;

        public UserReviewModelTests()
        {
            underTest = new UserReview("MoocJunkie", "Its free!", 3.7M);
        }
        
        [Fact]
        public void User_Review_Has_UserName()
        {
            string expected = "MoocJunkie";
            string model = underTest.UserName;

            Assert.Equal(expected, model);
        }

        [Fact]
        public void User_Review_Has_Comment()
        {
            string expected = "Its free!";
            string model = underTest.Comment;

            Assert.Equal(expected, model);
        }

        [Fact]
        public void User_Review_Has_Rating()
        {
            decimal expected = 3.7M;
            decimal model = underTest.Rating;

            Assert.Equal(expected, model);
        }

        [Fact]
        public void UserReview_Calculates_Solid_Stars()
        {
            var result = underTest.SolidStars();
            int expected = 3;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void UserReview_Calculates_Half_Stars()
        {
            var result = underTest.HalfStars();
            int expected = 1;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void UserReview_Calculates_Empty_Stars()
        {
            var result = underTest.EmptyStars();
            int expected = 1;

            Assert.Equal(expected, result);
        }
    }
}
