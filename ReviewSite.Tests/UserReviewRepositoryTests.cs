using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ReviewSite.Models;
using ReviewSite.Repositories;
namespace ReviewSite.Tests
{
  public  class UserReviewRepositoryTests
    {
        UserReviewRepository under_test;
        ReviewContext db;
        public  UserReviewRepositoryTests()
        {
            var context = new ReviewContext();
            under_test = new UserReviewRepository(context);
        }
        [Fact]
        public void UserReviewRepo_Returns_List()
        {
             
            var list = under_test.GetAll();
            Assert.IsType<List<UserReview>>(list);
        }
 
       
      
    }
}
