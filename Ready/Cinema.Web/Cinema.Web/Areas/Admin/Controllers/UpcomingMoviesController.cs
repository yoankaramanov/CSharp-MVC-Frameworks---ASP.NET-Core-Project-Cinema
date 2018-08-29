using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cinema.Data;
using Cinema.Models;
using Cinema.Web.Areas.Admin.Models.BindingModels;
using Cinema.Web.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Areas.Admin.Controllers
{
    public class UpcomingMoviesController : AdminController
    {
        private readonly CinemaContext context;
        private readonly IMapper mapper;

        public UpcomingMoviesController(
            CinemaContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var movies = this.context.UpcomingMovies.ToList();
            var model = this.mapper.Map<IEnumerable<MovieConciseViewModel>>(movies);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(MovieCreationBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var director = this.context.Directors.FirstOrDefault(d => d.FullName == model.Director);

            if (director == null)
            {
                director = new Director()
                {
                    FullName = model.Director,
                    ImageUrl = model.DirectorImageUrl
                };

                this.context.Directors.Add(director);
                this.context.SaveChanges();
            }


            var movie = new UpcomingMovie
            {
                Title = model.Title,
                Director = director,
                Genre = model.Genre,
                Lenght = model.Lenght,
                ReleaseDate = model.ReleaseDate,
                Actors = model.Actors,
                Description = model.Description,
                Reviews = new List<Review>(),
                ImageUrl = model.ImageUrl
            };


            if (this.context.UpcomingMovies.Any(m => m.Title == movie.Title) || this.context.Movies.Any(m => m.Title == movie.Title))
            {
                return RedirectToAction("Create", "UpcomingMovies", new { area = "admin" });
            }
           

            this.context.UpcomingMovies.Add(movie);
            context.SaveChanges();

            return RedirectToAction("Index", "UpcomingMovies", new { area = "admin" });
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var movie = this.context.UpcomingMovies.Include(m => m.Reviews).FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            var director = this.context.Directors.FirstOrDefault(d => d.Id == movie.DirectorId);

            var model = this.mapper.Map<MovieDetailsViewModel>(movie);

            model.Director = director;
            model.Reviews = movie.Reviews;

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = this.context.UpcomingMovies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            this.context.UpcomingMovies.Remove(movie);
            context.SaveChanges();


            return RedirectToAction("Index");
        }



        [HttpGet]
        public IActionResult Publish(int id)
        {
            var upcomingMovie = this.context.UpcomingMovies.FirstOrDefault(m => m.Id == id);

            if (upcomingMovie == null)
            {
                return NotFound();
            }

            this.context.UpcomingMovies.Remove(upcomingMovie);
            context.SaveChanges();

            var director = this.context.Directors.FirstOrDefault(d => d.Id == upcomingMovie.DirectorId);

            var movie = new Movie()
            {
                Title = upcomingMovie.Title,
                Director = director,
                Genre = upcomingMovie.Genre,
                Lenght = upcomingMovie.Lenght,
                ReleaseDate = upcomingMovie.ReleaseDate,
                Actors = upcomingMovie.Actors,
                Description = upcomingMovie.Description,
                Reviews = new List<Review>(),
                ImageUrl = upcomingMovie.ImageUrl
            };


            if (this.context.Movies.Any(m => m.Title == movie.Title))
            {
                return RedirectToAction("Create", "Movies", new { area = "admin" });
            }

            this.context.Movies.Add(movie);
            context.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}