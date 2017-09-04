﻿using MovieMenuDAL.Context;
using MovieMenuDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.UOW
{
    class UnitOfWorkMem : IUnitOfWork
    {
        public IMovieRepository MovieRepository { get; internal set; }
        public IGenreRepository GenreRepository { get; internal set; }
        private InMemoryContext context;

        public UnitOfWorkMem()
        {
            context = new InMemoryContext();
            MovieRepository = new MovieRepositoryEFMemory(context);
            GenreRepository = new GenreRepositoryEFMemory(context);
        }

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}
