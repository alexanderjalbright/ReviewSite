using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class CategoryRepositoryTests
    {
        CategoryRepository underTest;
        public CategoryRepositoryTests()
        {
            var context = new ReviewContext();

            underTest = new CategoryRepository(context);
        }

        [Fact]
        public void Category_Repo_Has_List()
        {
            var result = underTest.Count();
            int expected = 0;

            Assert.True(result > expected);
        }

        [Fact]
        public void Category_Repo_Returns_List()
        {
            var result = underTest.GetAll();

            Assert.IsType<List<Category>>(result);
        }

        [Fact]
        public void Category_Repo_Returns_Review_With_Matching_Id()
        {
            int expected = 1;

            var result = underTest.GetById(1).CategoryId;

            Assert.Equal(expected, result);
        }

    }
}
