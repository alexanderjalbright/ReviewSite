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
        ReviewRepository repo;
        public ReviewController(ReviewRepository repo)
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
            var model = repo.GetById(id);

            return View(model);
        }
    }
}