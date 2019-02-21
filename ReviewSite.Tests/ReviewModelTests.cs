using ReviewSite.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewModelTests
    {
        [Fact]
        public void Review_Has_Title()
        {
            string expected = "Machine Learning";
            Review underTest = new Review(expected);

            var result = underTest.Title;

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Review_Has_Id()
        {
            int expected = 1;
            Review underTest = new Review("Machine Learning", 1);

            var result = underTest.Id;

            Assert.Equal(expected, result);
        }
    }
}
