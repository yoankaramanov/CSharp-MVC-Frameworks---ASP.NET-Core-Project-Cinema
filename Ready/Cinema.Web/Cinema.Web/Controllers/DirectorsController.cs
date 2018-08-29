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
    public class DirectorsController : Controller
    {
        private readonly CinemaContext context;
        private readonly IMapper mapper;

        public DirectorsController(
            CinemaContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var directors = this.context.Directors.ToList();
            var model = this.mapper.Map<IEnumerable<DirectorConciseViewModel>>(directors);
            return View(model);
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var director = this.context.Directors
                .Include(d => d.Movies)
                .Include(a => a.UpcomingMovies)
                .FirstOrDefault(d => d.Id == id);

            var model = this.mapper.Map<DirectorDetailsViewModel>(director);

            model.Movies = director.Movies;
            model.UpcomingMovies = director.UpcomingMovies;

            return View(model);
        }

    }
}