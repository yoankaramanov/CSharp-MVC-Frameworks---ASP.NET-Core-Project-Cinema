using Cinema.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Areas.Admin.Models.ViewModels
{
    public class DirectorDetailsViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }
        
        public string ImageUrl { get; set; }

        public List<Movie> Movies { get; set; }

        public List<UpcomingMovie> UpcomingMovies { get; set; }
    }
}
