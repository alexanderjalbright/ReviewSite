using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewSite.Models;
using ReviewSite.Repositories;

namespace ReviewSite.Controllers
{
    public class CourseController : Controller
    {
        ICourseRepository repo;
        public CourseController(ICourseRepository repo)
        {
            this.repo = repo;
        }

        public ViewResult Index()
        {
            var model = repo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = new CourseAndUserReview();
            model.Course = repo.GetById(id);
            model.NewUserReview.CourseId = id;

            return View(model);
        }

        [HttpPost]
        public ActionResult CreateUserReview(CourseAndUserReview model)
        {
            repo.CreateUserReview(model.NewUserReview);
            return RedirectToAction("Details/" + model.NewUserReview.CourseId);
        }
        
        public ActionResult DeleteUserReview(UserReview model)
        {
            repo.DeleteUserReview(model);
            return RedirectToAction("Details/" + model.CourseId);
        }

        [HttpPost]
        public ActionResult EditUserReview(CourseAndUserReview model)
        {
            repo.EditUserReview(model.Course.UserReviews);
            return RedirectToAction("Details/" + model.Course.UserReviews[0].CourseId);
        }
    }
}