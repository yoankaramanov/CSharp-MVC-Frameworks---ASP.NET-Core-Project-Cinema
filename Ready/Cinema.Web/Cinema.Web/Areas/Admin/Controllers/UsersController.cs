using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Cinema.Data;
using Cinema.Models;
using Cinema.Web.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.Web.Areas.Admin.Controllers
{
    public class UsersController : AdminController
    {
        private readonly CinemaContext context;
        private readonly IMapper mapper;
        private readonly UserManager<User> userManager;

        public UsersController(
            CinemaContext context, 
            IMapper mapper,
            UserManager<User> userManager)
        {
            this.context = context;
            this.mapper = mapper;
            this.userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var currentUser = await this.userManager.GetUserAsync(this.User);
            var users = this.context.Users
                .Where(u => u.Id != currentUser.Id)
                .ToList();

            

            // TODO: Fill in "Is lecturer" -> whether user is in role "Lecturer"?
            // TODO: Is admin
            
            // If administrator -> only "Details"
            var model = this.mapper.Map<IEnumerable<UserConciseViewModel>>(users);
            return View(model);
        }


        public IActionResult Details(string id)
        {
            
            var user =  this.context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }
            var model = this.mapper.Map<UserDetailsViewModel>(user);           
            return View(model);
        }


        public IActionResult Ban(string id)
        {

            var user = this.context.Users.Find(id);

            if (user == null)
            {
                return NotFound();
            }

            user.LockoutEnd = DateTime.Parse("Jan 1, 2030");
            context.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}