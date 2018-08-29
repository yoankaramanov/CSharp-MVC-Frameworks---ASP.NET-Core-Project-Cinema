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
    public class DirectorsController : AdminController
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
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(DirectorCreationBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }



            var director = this.mapper.Map<Director>(model);

            director.Movies = new List<Movie>();
            director.UpcomingMovies = new List<UpcomingMovie>();



            if (this.context.Directors.Any(m => m.FullName == director.FullName))
            {
                return RedirectToAction("Create", "Directors", new { area = "admin" });
            }

            this.context.Directors.Add(director);
            context.SaveChanges();

            return RedirectToAction("Index", "Directors", new { area = "admin" });


           
        }


        [HttpGet]
        public IActionResult Details(int id)
        {
            var director = this.context.Directors
                .Include(d => d.Movies)
                .Include(a => a.UpcomingMovies)
                .FirstOrDefault(d => d.Id == id);

            if (director == null)
            {
                return NotFound();
            }

            var model = this.mapper.Map<DirectorDetailsViewModel>(director);

            model.Movies = director.Movies;
            model.UpcomingMovies = director.UpcomingMovies;

            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var director = this.context.Directors.Single(m => m.Id == id);

            if (director == null)
            {
                return NotFound();
            }

            this.context.Directors.Remove(director);
            context.SaveChanges();


            return RedirectToAction("Index");
        }
    }
}