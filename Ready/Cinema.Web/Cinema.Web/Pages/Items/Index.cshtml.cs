using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cinema.Data;
using Cinema.Web.Areas.Admin.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Cinema.Pages.Items
{
    public class IndexModel : PageModel
    {
        public IndexModel(CinemaContext context)
        {
            this.Context = context;
        }

        public CinemaContext Context { get; set; }

        public IEnumerable<ItemsConciseViewModel> Items { get; set; }

        public void OnGet()
        {
            this.Items = this.Context
                .Items             
                .Select(i => new ItemsConciseViewModel
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description,
                    ImageUrl = i.ImageUrl,
                    Price = i.Price
                    
                })
                .ToList();
        }
    }
}