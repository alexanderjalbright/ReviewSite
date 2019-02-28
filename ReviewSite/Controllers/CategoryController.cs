using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ReviewSite.Repositories;

namespace ReviewSite.Controllers
{
    public class CategoryController : Controller
    {
        
        CategoryRepository repo;
        CourseController controller;
        public CategoryController(CategoryRepository repo, CourseController controller)
        {
            this.repo = repo;
            this.controller = controller;
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