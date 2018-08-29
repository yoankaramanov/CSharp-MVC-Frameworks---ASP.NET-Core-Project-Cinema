using Cinema.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cinema.Tests.Mocks
{
    public static class MockDbContext
    {
        public static CinemaContext GetContext()
        {
            var options = new DbContextOptionsBuilder<CinemaContext>()
                            .UseInMemoryDatabase(Guid.NewGuid().ToString())
                            .Options;

            return new CinemaContext(options);
        }
    }
}
