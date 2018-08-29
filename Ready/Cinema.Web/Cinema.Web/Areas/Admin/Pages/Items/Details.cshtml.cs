using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Web.Areas.Admin.Pages.Items
{
    public class DetailsModel : PageModel
    {
        public DetailsModel(CinemaContext context)
        {
            this.Context = context;
        }

        

        public CinemaContext Context { get; set; }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public double Price { get; set; }

       

        public IActionResult OnGet(int id)
        {
            var item = this.Context
                .Items
                .FirstOrDefault(b => b.Id == id);

            if (item == null)
            {
                return this.NotFound();
            }

            this.Id = item.Id;
            this.Name = item.Name;
            this.Description = item.Description;
            this.ImageUrl = item.ImageUrl;
            this.Price = item.Price;
               
            return this.Page();
        }


        public IActionResult OnPostDeleteItem(int id)
        {
            var item = this.Context.Items.FirstOrDefault(m => m.Id == id);

            this.Context.Items.Remove(item);
            Context.SaveChanges();


            return this.RedirectToPage("/Items/Index");
        }

    }
}