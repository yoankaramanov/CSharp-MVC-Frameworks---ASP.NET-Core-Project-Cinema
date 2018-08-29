using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Areas.Admin.Models.BindingModels
{
    public class DirectorCreationBindingModel
    {
        [Required, MinLength(2)]
        public string FullName { get; set; }
        
       public string ImageUrl { get; set; }
    }
}
