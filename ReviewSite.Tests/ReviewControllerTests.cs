using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReviewSite.Controllers;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System.Collections.Generic;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewControllerTests
    {
        CourseController underTest;

        public ReviewControllerTests()
        {
            var context = new ReviewContext();
            var repository = new CourseRepository(context);

            underTest = new CourseController(repository);
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

            Assert.IsType<List<Course>>(model);
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

            Assert.IsType<Course>(model);
        }
    }
}
