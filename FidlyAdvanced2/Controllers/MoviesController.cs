using FidlyAdvanced2.Models;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

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
            var movies = _context.Movies.Include(c => c.GenreType).ToList();
            return View(movies);
        }

        [Route("Movies/Details/{id}")]
        public ActionResult Details(int? id)
        {
            if (id == null)
                id = 1;
            var movie = _context.Movies.Include(c => c.GenreType).SingleOrDefault(c => c.Id == id);
            return View(movie);
        }

        public ActionResult NewMovie()
        {
            return View();
        }

        public ActionResult Save(Movie movie)
        {
            if (movie.Id == 0)
                _context.Movies.Add(movie);
            else
            {
                var movieInDb = _context.Movies.Single(m => m.Id == movie.Id);
                movieInDb.Name = movie.Name;
                movieInDb.ReleaseDate = movie.ReleaseDate;
                movieInDb.GenreType.Name = movie.GenreType.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return View();
        }
    }
}