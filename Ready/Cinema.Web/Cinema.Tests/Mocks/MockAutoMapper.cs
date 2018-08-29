using AutoMapper;
using Cinema.Web.Mapping;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Tests.Mocks
{
    public static class MockAutoMapper
    {
        static MockAutoMapper()
        {
            Mapper.Initialize(config => config.AddProfile<AutoMapperProfile>());

        }

        public static IMapper GetAutoMapper() => Mapper.Instance;
    }
}
