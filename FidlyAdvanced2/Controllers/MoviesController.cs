using FidlyAdvanced2.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FidlyAdvanced2.ViewModels;

namespace FidlyAdvanced2.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index()
        {
            if (User.IsInRole(RoleName.CanManageMovies))
                return View("List");

            return View("ReadOnlyList");
        }

        [Route("Movies/Details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
                id = 1;
            var movie = _context.Movies.Include(c => c.GenreType).SingleOrDefault(c => c.Id == id);
            var viewModel = new MovieFormViewModel (movie)
            {
                GenreTypes = _context.GenreTypes.ToList()
            };

            return View("MovieForm", viewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovies)]
        public ActionResult MovieForm()
        {
            var viewModel = new MovieFormViewModel
            {
                GenreTypes = _context.GenreTypes.ToList()
            };

            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new MovieFormViewModel (movie)
                {
                    GenreTypes = _context.GenreTypes
                };
                return View("MovieForm", viewModel);
            }
            if (movie.Id == 0)
            {
                movie.AddedDate = DateTime.Now;
                _context.Movies.Add(movie);
            }
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreTypeId = movie.GenreTypeId;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
    }
}