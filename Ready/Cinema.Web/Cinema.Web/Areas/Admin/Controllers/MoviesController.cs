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
    public class MoviesController : AdminController
    {
        private readonly CinemaContext context;
        private readonly IMapper mapper;

        public MoviesController(
            CinemaContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var movies = this.context.Movies.ToList();
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


            var movie = new Movie
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

            
            if (this.context.Movies.Any(m => m.Title == movie.Title))
            {                           
                return RedirectToAction("Create", "Movies", new { area = "admin" });
            }

            this.context.Movies.Add(movie);
            context.SaveChanges();
            
            return RedirectToAction("Index","Movies",new { area = "admin"});
        }

        [HttpGet]
        public IActionResult Details(int id)
        {            
            var movie = this.context.Movies.Include(m => m.Reviews).FirstOrDefault(m => m.Id == id);

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
            var movie = this.context.Movies.FirstOrDefault(m => m.Id == id);

            if (movie == null)
            {
                return NotFound();
            }

            this.context.Movies.Remove(movie);
            context.SaveChanges();


            return RedirectToAction("Index");
        }


        [HttpGet]
        public IActionResult Program()
        {
            var movies = this.context.Movies.Take(7).ToList();
            var model = this.mapper.Map<IEnumerable<MovieConciseViewModel>>(movies);
            return View(model);
        }


    }
}