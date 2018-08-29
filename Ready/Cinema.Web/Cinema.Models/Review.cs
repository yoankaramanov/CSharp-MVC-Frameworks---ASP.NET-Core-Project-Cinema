using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models
{
   public class Review
    {
        public int Id { get; set; }

        [Required, MinLength(100, ErrorMessage = "Minimum length required is 100")]
        public string Description { get; set; }

        [Required]
        public Movie Moive { get; set; }

        [Required, MinLength(3, ErrorMessage = "Minimum length required is 3")]
        public string UserName { get; set; }

        [Required]
        [Range(0, 5)]
        public int Rating { get; set; }


    }
}
