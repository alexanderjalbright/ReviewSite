using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReviewSite.Controllers;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class CategoryControllerTests
    {
        CategoryController underTest;
        public CategoryControllerTests()
        {
            var context = new ReviewContext();
            var categoryRepo = new CategoryRepository(context);
            var reviewRepo = new CourseRepository(context);
            var reviewCont = new CourseController(reviewRepo);

            underTest = new CategoryController(categoryRepo, reviewCont);
        }

        [Fact]
        public void Index_Has_A_View()
        {
            var result = underTest.Index();

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Index_Gets_List()
        {
            var model = underTest.Index().Model;

            Assert.IsType<List<Category>>(model);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            var result = underTest.Details(1);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Given_Review()
        {
            var model = underTest.Details(1).Model;

            Assert.IsType<Category>(model);
        }
    }
}
