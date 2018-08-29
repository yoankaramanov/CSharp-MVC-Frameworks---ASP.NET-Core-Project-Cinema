using System;
using System.Collections.Generic;
using System.Text;
using Cinema.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Data
{
    public class CinemaContext : IdentityDbContext<User>
    {
        public CinemaContext(DbContextOptions<CinemaContext> options)
            : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Director> Directors { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<Item> Items { get; set; }

        public  DbSet<UpcomingMovie> UpcomingMovies { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder
                .Entity<Director>()
                .HasMany(d => d.Movies)
                .WithOne(m => m.Director)
                .HasForeignKey(m => m.DirectorId);
            builder
               .Entity<Director>()
               .HasMany(d => d.UpcomingMovies)
               .WithOne(m => m.Director)
               .HasForeignKey(m => m.DirectorId);

        }
    }
}
