using Microsoft.EntityFrameworkCore;
using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.Context
{
    class MovieContext : DbContext
    {
        static DbContextOptions<MovieContext> options =
            new DbContextOptionsBuilder<MovieContext>().UseInMemoryDatabase("TheDB").Options;
        public MovieContext() : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Rental> Rentals { get; set; }
    }
}
