using System.Collections.Generic;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>
            {
                new Movie { Name = "Sherk"},
                new Movie { Name = "Wall-e"},
                new Movie { Name = "Valiente"}
            };
            var viewModel = new MovieViewModel
            {
                Movies = movies
            };

            return View(viewModel);
        }
    }
}