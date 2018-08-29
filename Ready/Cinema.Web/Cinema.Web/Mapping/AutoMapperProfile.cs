using AutoMapper;
using Cinema.Models;
using Cinema.Web.Areas.Admin.Models.BindingModels;
using Cinema.Web.Areas.Admin.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Web.Mapping
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            this.CreateMap<User, UserConciseViewModel>();
            this.CreateMap<User, UserDetailsViewModel>();
            this.CreateMap<MovieCreationBindingModel, Movie>();
            this.CreateMap<Movie, MovieConciseViewModel>();
            this.CreateMap<DirectorCreationBindingModel, Director>();
            this.CreateMap<Director, DirectorConciseViewModel>();
            this.CreateMap<ReviewCreationBindingModel, Review>();
            this.CreateMap<MovieCreationBindingModel, UpcomingMovie>();
            this.CreateMap<UpcomingMovie, MovieConciseViewModel>();

        }
    }
}
