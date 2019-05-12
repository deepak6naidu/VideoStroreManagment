using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using videoManagment.Models;

namespace videoManagment.Controllers
{
    public class MoviesController : Controller
    {
        // GET Movies/Random
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Fast and Furious" };
            return View(movie);
            //return Content("Hellow World");
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int id)
        {
            return Content("id = " + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(string.Format("pageIndex={0}&sortBy={1}",pageIndex,sortBy));
        }
    }
}