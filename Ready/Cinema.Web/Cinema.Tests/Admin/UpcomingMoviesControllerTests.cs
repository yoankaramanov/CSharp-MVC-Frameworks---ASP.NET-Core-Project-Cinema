using AutoMapper;
using Cinema.Data;
using Cinema.Models;
using Cinema.Tests.Mocks;
using Cinema.Web.Areas.Admin.Controllers;
using Cinema.Web.Areas.Admin.Models.BindingModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Tests.Admin
{
    [TestClass]
    public class UpcomingMoviesControllerTests
    {
        private CinemaContext dbContext;
        private IMapper mapper;

        [TestMethod]
        public void Publish_WithValidId_MovesTheMovie()
        {

            var inputMovie = new MovieCreationBindingModel()
            {
                
                Title = "firsts",
                Genre = "action",
                Lenght = 122,
                Director = "Jon",
                Description = "dsgdsgdsgdsgdsgdsgdsgdsghthrthrtjdfdfhtrjtrj",
                ReleaseDate = DateTime.Parse("Jan 1, 2030")
            };

            var controller = new UpcomingMoviesController(dbContext, mapper);
          
            controller.Create(inputMovie);
            dbContext.SaveChanges();

            var movie = dbContext.UpcomingMovies.First();
            controller.Publish(movie.Id);

            var movies = dbContext.Movies.ToList();
            var upcomingMovies = dbContext.UpcomingMovies.ToList();

            Assert.AreEqual(1,movies.Count);
            Assert.AreEqual(0, upcomingMovies.Count);
        }

    [TestInitialize]
    public void InitializeTests()
    {
        this.dbContext = MockDbContext.GetContext();
        this.mapper = MockAutoMapper.GetAutoMapper();
    }
}
}
