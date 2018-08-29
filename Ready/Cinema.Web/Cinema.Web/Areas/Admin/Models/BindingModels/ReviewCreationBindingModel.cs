using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Areas.Admin.Models.BindingModels
{
    public class ReviewCreationBindingModel
    {
        [Required, MinLength(2)]
        public string UserName { get; set; }

        [Required, MinLength(20)]
        public string Description { get; set; }

        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
    }
}
