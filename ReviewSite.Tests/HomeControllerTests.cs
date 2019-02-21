using Microsoft.AspNetCore.Mvc;
using ReviewSite.Controllers;
using System;
using Xunit;

namespace ReviewSite.Tests
{
    public class HomeControllerTests
    {
        HomeController underTest;

        public HomeControllerTests()
        {
            underTest = new HomeController();
        }

        [Fact]
        public void Home_Has_A_View()
        {
            var model = underTest.Index();

            Assert.IsType<ViewResult>(model);
        }


    }
}
