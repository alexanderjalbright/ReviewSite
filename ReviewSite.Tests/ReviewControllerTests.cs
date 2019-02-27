using Microsoft.AspNetCore.Mvc;
using ReviewSite.Controllers;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewControllerTests
    {
        ReviewController underTest;

        public ReviewControllerTests()
        {
            underTest = new ReviewController(new ReviewRepository(new ReviewContext()));
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

            Assert.IsType<List<Review>>(model);
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

            Assert.IsType<Review>(model);
        }


    }
}
