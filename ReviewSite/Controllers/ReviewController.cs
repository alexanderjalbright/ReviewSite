using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewSite.Repositories;

namespace ReviewSite.Controllers
{
    public class ReviewController : Controller
    {
        public ViewResult Index()
        {
            ReviewRepository reviewRepo = new ReviewRepository();

            var model = reviewRepo.GetAll();

            return View(model);
        }

        public ViewResult Details(int id)
        {
            ReviewRepository reviewRepo = new ReviewRepository();

            var model = reviewRepo.GetById(id);
            return View(model);
        }
    }
}