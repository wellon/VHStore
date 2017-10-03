using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VHStore.Models;
using VHStore.ViewModels;

namespace VHStore.Controllers
{
    public class MoviesController : Controller
    {

        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie{Name = "Shrek!"},
                new Movie{Name = "Wall-e"}
            };

            return View(movies);
        }

        public ActionResult Random()
        {
            var movie = new Movie{Id = 1, Name = "Shrek!"};

            var customers = new List<Customer>
            {
                new Customer{ Name = "Customer1"},
                new Customer{ Name = "Customer2"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        [Route("movies/release/{year}/{month:regex(\\d{4}):range(1, 12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content($"{year}/{month}");
        }
    }
}