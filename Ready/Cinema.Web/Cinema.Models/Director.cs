using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models
{
    public class Director
    {
        public Director()
        {
            this.Movies = new List<Movie>();
            this.UpcomingMovies = new List<UpcomingMovie>();
        }

        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Minimum length required is 3")]
        [MaxLength(100)]
        public string FullName { get; set; }

        public List<Movie> Movies { get; set; }

        public List<UpcomingMovie> UpcomingMovies { get; set; }

        public string ImageUrl { get; set; }

    }
}
