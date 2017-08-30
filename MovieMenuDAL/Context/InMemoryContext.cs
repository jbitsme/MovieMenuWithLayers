using Microsoft.EntityFrameworkCore;
using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.Context
{
    class InMemoryContext : DbContext
    {
        static DbContextOptions<InMemoryContext> options =
            new DbContextOptionsBuilder<InMemoryContext>().UseInMemoryDatabase("TheDB").Options;
        public InMemoryContext() : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

    }
}
