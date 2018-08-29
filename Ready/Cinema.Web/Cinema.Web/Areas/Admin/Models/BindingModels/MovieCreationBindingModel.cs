using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Areas.Admin.Models.BindingModels
{
    public class MovieCreationBindingModel
    {
      

        [Required, MinLength(1)]
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }
        
        [Required]
        public int Lenght { get; set; }


        [Required]
        public string Director { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public string Actors { get; set; }

        [Required, MinLength(20)]
        public string Description { get; set; }      

        public string ImageUrl { get; set; }

        public string DirectorImageUrl { get; set; }
    }
}
