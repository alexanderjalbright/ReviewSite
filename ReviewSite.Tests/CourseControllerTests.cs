using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ReviewSite.Controllers;
using ReviewSite.Models;
using ReviewSite.Repositories;
using System.Collections.Generic;

using NSubstitute;
using Xunit;

namespace ReviewSite.Tests
{
    public class ReviewControllerTests
    {
        CourseController underTest;
        ICourseRepository repo;
        public ReviewControllerTests()
        {
            repo = Substitute.For<ICourseRepository>();
            underTest = new CourseController(repo);
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
            var expectedmodel = new List<Course>();
            repo.GetAll().Returns(expectedmodel);

            var actualModel = underTest.Index().Model;

            Assert.Equal(expectedmodel, actualModel);
        }

        [Fact]
        public void Details_Has_A_View()
        {
            int id = 1;
            var result = underTest.Details(id);

            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Gets_Course()
        {
            var expectedId = 1;
            var expectedCourse = new Course();
            repo.GetById(expectedId).Returns(expectedCourse);

            var model = (CourseAndUserReview)underTest.Details(expectedId).Model;

            Assert.Equal(model.Course, expectedCourse);             
        }

        [Fact]
        public void Details_Gets_UserReview()
        {
            var expectedId = 1;
            var expectedCourse = new Course() { CourseId = expectedId };
            repo.GetById(expectedId).Returns(expectedCourse);

            var model = (CourseAndUserReview)underTest.Details(expectedId).Model;

            Assert.Equal(model.NewUserReview.CourseId, expectedId);
        }
    }
}
