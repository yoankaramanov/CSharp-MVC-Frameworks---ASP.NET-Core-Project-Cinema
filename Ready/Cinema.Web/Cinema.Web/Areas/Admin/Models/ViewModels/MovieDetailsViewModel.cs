using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Areas.Admin.Models.ViewModels
{
    public class MovieDetailsViewModel
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public Director Director { get; set; }

        public string Lenght { get; set; }

        public DateTime ReleaseDate { get; set; }

        public string Actors { get; set; }

        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public List<Review> Reviews { get; set; }


    }
}
