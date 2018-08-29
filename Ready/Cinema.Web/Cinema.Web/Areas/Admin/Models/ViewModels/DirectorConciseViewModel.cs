using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Areas.Admin.Models.ViewModels
{
    public class DirectorConciseViewModel
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public string ImageUrl { get; set; }
    }
}
