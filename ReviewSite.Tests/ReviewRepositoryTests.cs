using ReviewSite.Models;
using ReviewSite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewRepositoryTests
    {
        [Fact]
        public void Review_Repo_Has_List()
        {
            var underTest = new ReviewRepository();

            var result = underTest.Count();
            int expected = 0;

            Assert.True(result > expected);
        }

        [Fact]
        public void Review_Repo_Returns_List()
        {
            var underTest = new ReviewRepository();

            var result = underTest.GetAll();

            Assert.IsType<List<Review>>(result);
        }

        [Fact]
        public void Review_Repo_Returns_A_Review()
        {
            var underTest = new ReviewRepository();

            var result = underTest.GetById(1);

            Assert.IsType<Review>(result);
        }

        [Fact]
        public void Review_Repo_Returns_Review_With_Matching_Id()
        {
            var underTest = new ReviewRepository();
            int expected = 1;

            var result = underTest.GetById(1).Id;

            Assert.Equal(expected, result);
        }
    }
}
