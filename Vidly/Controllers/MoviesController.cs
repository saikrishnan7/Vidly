using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };
            var viewModel = new RandomMovieViewModel();
            return View(viewModel);
        }
        public ActionResult Index()
        {
            return View(GetMovies());
        }

        private IEnumerable<Movie> GetMovies()
        {
            var mList = new List<Movie>();
            mList.Add(new Movie { Id = 1, Name = "Mary Shrek!!" });
            mList.Add(new Movie { Id = 2, Name = "Wall-e" });
            return mList;
        }
        [Route("movies/released/{year}/{month:regex(\\d{2})}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}