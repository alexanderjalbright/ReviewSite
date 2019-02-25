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
            underTest = new UserReview("MoocJunkie", "Its free!", 3.3M);
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
            decimal expected = 3.3M;
            decimal model = underTest.Rating;

            Assert.Equal(expected, model);
        }
    }
}
