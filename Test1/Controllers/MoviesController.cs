using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;
using Test1.ViewModel;

namespace Test1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie { Name = "Shrek" };
            // ViewData["RandomMovie"] = movie;
            // ViewBag.RandomMovie = movie;
            //var viewResult = new ViewResult();
            //viewResult.viewData.Model;
            var customers = new List <Customer>
            {
                new Customer{Name= "Cus 1"},
                new Customer{Name= "Cus 2"}
            };

            var viewModel = new RandomViewModel
               { Movie = movie,
                Customer= customers
                };

            return View(viewModel);
                       
            //return word in the bracket
            //return Content("Hello World!!");
            //return page not found
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
       
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        //movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortBy={1}", pageIndex,sortBy));
        }
        
        [Route("movies/released/{year}/{months:regex(\\d{2}): range (1,12))}")]
        public ActionResult ByReleaseDate( int year, int months)
        {
            return Content(year + "/" + months);
        }

      
    }
}