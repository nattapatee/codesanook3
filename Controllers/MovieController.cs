using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SanookMovie.Models;

namespace SanookMovie.Controllers
{
    public class MovieController : Controller
    {
        static IList<Movie> _movies = new List<Movie>();
        public IActionResult Index()
        {
            return View(_movies);
        }
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Movie movie) {
            movie.id = _movies.Count +1;
            _movies.Add(movie);
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Detail()
        {
            return View();
        }
        public IActionResult Delete(int id)
        {
            var movie = _movies.FirstOrDefault(x => x.id ==id);
            if (movie == null) {
                return NotFound();
            }
            return View(movie);
        }
        public IActionResult DeleteConfirm(int id) {
             var movie = _movies.FirstOrDefault(x => x.id ==id);
            if (movie == null) {
                return NotFound();
            }

            _movies.Remove(movie);
            return RedirectToAction(nameof(Index));
        }
       public MovieController()
       {
        // var movies = _movies;
        // _movies.Add("Titanic");
        // _movies.Add("Avenger");
        // _movies.Add("Alita");
       }
    }
}
