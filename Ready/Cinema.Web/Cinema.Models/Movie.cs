using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace Cinema.Models
{
    public class Movie
    {
        public Movie()
        {
            this.Reviews = new List<Review>();
        }

        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Minimum length required is 3")]      
        public string Title { get; set; }

        [Required]
        public string Genre { get; set; }

        public int DirectorId { get; set; }

        public Director Director { get; set; }

        [Required]
        public int Lenght { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public string Actors { get; set; }

        [Required, MinLength(20, ErrorMessage = "Minimum length required is 20")]        
        public string Description { get; set; }

        public List<Review> Reviews { get; set; }

        public string ImageUrl { get; set; }

        public double Rating => this.Reviews.Average(r => r.Rating);
    }
}
