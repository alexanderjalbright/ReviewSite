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
        CourseRepository repo;
        public CourseController(CourseRepository repo)
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
        public ActionResult Create(CourseAndUserReview model)
        {
            repo.CreateUserReview(model.NewUserReview);
            return RedirectToAction("Details/" + model.NewUserReview.CourseId);
        }
    }
}