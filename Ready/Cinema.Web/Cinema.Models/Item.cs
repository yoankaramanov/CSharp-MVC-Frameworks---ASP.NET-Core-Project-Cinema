using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Cinema.Models
{
    public class Item
    {
        public int Id { get; set; }

        [Required, MinLength(3, ErrorMessage = "Minimum length required is 3")]
        [MaxLength(100)]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public string ImageUrl { get; set; }

        [Required, MinLength(20, ErrorMessage = "Minimum length required is 20")]        
        public string Description { get; set; }
    }
}
