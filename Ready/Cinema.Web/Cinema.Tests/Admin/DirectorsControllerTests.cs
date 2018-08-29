using AutoMapper;
using Cinema.Data;
using Cinema.Models;
using Cinema.Tests.Mocks;
using Cinema.Web.Areas.Admin.Controllers;
using Cinema.Web.Areas.Admin.Models.BindingModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cinema.Tests
{
    [TestClass]
    public class DirectorsControllerTests
    {

        private CinemaContext dbContext;
        private IMapper mapper;

        [TestMethod]
        public void Index_WithSomeDirectors_ReturnsAll()
        {
            //Arrange

            var directors = new List<Director>()
            {
                new Director(){Id = 1,FullName = "one"},
                new Director(){Id = 2,FullName = "two"},
                new Director(){Id = 3,FullName = "three"},
                new Director(){Id = 4,FullName = "four"}
            };
            this.dbContext.Directors.AddRange(directors);
            this.dbContext.SaveChanges();

            Assert.IsNotNull(directors);
            Assert.AreEqual(4, directors.Count);
            CollectionAssert.AreEqual(new[] { 1, 2, 3, 4 }, directors.Select(d => d.Id).ToArray());
        }


        [TestMethod]
        public void Index_WithNoDirectors_ReturnsNone()
        {
            //Arrange


            var directors = dbContext.Directors.ToList();

            Assert.AreEqual(0, directors.Count);

        }



        [TestMethod]
        public void Create_SameDirectorName_DoesntAdd()
        {

            var firstDirector = new DirectorCreationBindingModel()
            {
               
                FullName = "first"
            };

            var secondDirector = new DirectorCreationBindingModel()
            {
                
                FullName = "first"
            };

            var controller = new DirectorsController(dbContext, mapper);

            controller.Create(firstDirector);
            controller.Create(secondDirector);

            var directors = dbContext.Directors.ToList();
            Assert.AreEqual(1, directors.Count);
        }



        [TestMethod]
        public void Delete_WithValidId_DeletesDirector()
        {

            var firstDirector = new Director()
            {
                Id = 1,
                FullName = "first"
            };

            dbContext.Directors.Add(firstDirector);
            dbContext.SaveChanges();
            var controller = new DirectorsController(dbContext, mapper);

            controller.Delete(1);

            var directors = dbContext.Directors.ToList();
            Assert.AreEqual(0, directors.Count);
        }


        [TestMethod]
        public void Details_WithNonExistentId_ReturnsNotFound()
        {

            var firstDirector = new Director()
            {
                Id = 1,
                FullName = "first"
            };

            dbContext.Directors.Add(firstDirector);
            dbContext.SaveChanges();
            var controller = new DirectorsController(dbContext, mapper);

            var result = controller.Details(2);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }



        [TestMethod]
        public void Details_WithNegativetId_ReturnsNoutFound()
        {

            var firstDirector = new Director()
            {
                Id = 1,
                FullName = "first"
            };

            dbContext.Directors.Add(firstDirector);
            dbContext.SaveChanges();
            var controller = new DirectorsController(dbContext, mapper);

            var result = controller.Details(-5);

            Assert.IsInstanceOfType(result, typeof(NotFoundResult));
        }


        [TestInitialize]
        public void InitializeTests()
        {
            this.dbContext = MockDbContext.GetContext();
            this.mapper = MockAutoMapper.GetAutoMapper();
        }
    }
}
