using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Data;
using Cinema.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Web.Areas.Admin.Pages.Items
{
    public class CreateModel : PageModel
    {
        public CreateModel(CinemaContext context)
        {
            this.Context = context;
        }

        public CinemaContext Context { get; set; }

        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Description { get; set; }

        [BindProperty]
        [Display(Name = "Image URL")]
        [Url]
        public string ImageUrl { get; set; }

        [BindProperty]
        public double Price { get; set; }

        public IActionResult OnPostAddItem()
        {
            if (!ModelState.IsValid)
            {
                return this.Page();
            }

           
            var item = new Item
            {
                Name = this.Name,
                Price = this.Price,
                ImageUrl = this.ImageUrl,
                Description = this.Description
            };

            if (this.Context.Items.Any(m => m.Name == item.Name))
            {
                return this.RedirectToPage("/Items/Create");
            }

            this.Context.Items.Add(item);
            this.Context.SaveChanges();

            return this.RedirectToPage("/Items/Details", new { id = item.Id });
        }

        public IActionResult OnPostCancel()
        {
            return this.RedirectToPage("/Index");
        }
    }
}