using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cinema.Data;
using Cinema.Models;
using Cinema.Web.Areas.Admin.Models.BindingModels;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Controllers
{
    public class ReviewsController : Controller
    {
        private readonly CinemaContext context;
        private readonly IMapper mapper;

        public ReviewsController(
            CinemaContext context,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(int id, ReviewCreationBindingModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var movie = this.context.Movies.FirstOrDefault(m => m.Id == id);

            var review = this.mapper.Map<Review>(model);
            review.Moive = movie;



            this.context.Reviews.Add(review);
            context.SaveChanges();

            return RedirectToAction("Index", "Movies", new { area = "" });

        }
    }
}