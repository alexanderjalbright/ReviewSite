using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReviewSite.Controllers;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;

namespace ReviewSite.Tests
{
    public class CategoryControllerTests
    {
        CategoryController underTest;
        ICategoryRepository repo;
        public CategoryControllerTests()
        {
            repo = Substitute.For<ICategoryRepository>();

            underTest = new CategoryController(repo);
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
            var expectedModel = new List<Category>();            
            repo.GetAll().Returns(expectedModel);

            var result = underTest.Index().Model;
           
            Assert.Equal(expectedModel, result);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            int id = 1;
            var result = underTest.Details(id);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Given_Review()
        {
            var expectedId = 1;
            var expectedModel = new Category();
            repo.GetById(expectedId).Returns(expectedModel);

            var model = underTest.Details(expectedId).Model;

             Assert.Equal(expectedModel, model);
        }
    }
}
