using FidlyAdvanced2.Models;
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
            var movies = _context.Movies.ToList();
            /*var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Aladdin" },
                new Movie { Id = 2, Name = "Ne Zha" }
            };*/
            return View(movies);
        }
    }
}