
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
 
using ReviewSite.Models;
 
namespace ReviewSite.Tests
{
    public class CategoryModelTests
    {
        Category underTest;

        public CategoryModelTests()
        {
            underTest = new Category() { Name = "C#", CategoryId = 1};
        }

        [Fact]
        public void Category_Has_Name()
        {
            var result = underTest.Name;
            var expected = "C#";

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Category_Has_Id()
        {
            var result = underTest.CategoryId;
            var expected = 1;

            Assert.Equal(expected, result);
        }
    }
}
