using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cinema.Data;
using Cinema.Web.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Controllers
{
    public class UpcomingMoviesController : Controller
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
        public IActionResult Details(int id)
        {
            var movie = this.context.UpcomingMovies.Include(m => m.Reviews).FirstOrDefault(m => m.Id == id);

            var director = this.context.Directors.FirstOrDefault(d => d.Id == movie.DirectorId);

            var model = this.mapper.Map<MovieDetailsViewModel>(movie);

            model.Director = director;
            model.Reviews = movie.Reviews;

            return View(model);
        }

    }
}