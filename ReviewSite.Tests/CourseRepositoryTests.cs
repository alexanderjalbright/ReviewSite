﻿using Microsoft.EntityFrameworkCore;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using NSubstitute;
namespace ReviewSite.Tests
{
    public class CourseRepositoryTests
    {
        CourseRepository underTest;

        public CourseRepositoryTests()
        {
            var context = new ReviewContext();

            underTest = new CourseRepository(context);
        }

        [Fact]
        public void Course_Repo_Has_List()
        {
            var result = underTest.Count();
            int expected = 0;

            Assert.True(result > expected);
        }

        [Fact]
        public void Course_Repo_Returns_List()
        {
            var result = underTest.GetAll();

            Assert.IsType<List<Course>>(result);
        }

        [Fact]
        public void Course_Repo_Returns_Review_With_Matching_Id()
        {
            int expected = 1;

            var result = underTest.GetById(1).CourseId;

            Assert.Equal(expected, result);
        }
    }
}
