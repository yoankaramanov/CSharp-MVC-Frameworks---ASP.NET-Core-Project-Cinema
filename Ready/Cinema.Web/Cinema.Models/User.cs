using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models
{
    public class User : IdentityUser
    {
        public User()
        {
            this.FavouriteMovies = new List<Movie>();   
        }

        [Required]
        public string FullName { get; set; }



        public ICollection<Movie> FavouriteMovies { get; set; }

    }
}
