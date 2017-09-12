using MovieMenuDAL.Context;
using MovieMenuDAL.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL.UOW
{
    class UnitOfWork : IUnitOfWork
    {
        public IMovieRepository MovieRepository { get; internal set; }
        public IRentalRepository RentalRepository { get; internal set; }
        private MovieContext context;

        public UnitOfWork()
        {
            context = new MovieContext();
            MovieRepository = new MovieRepositoryEFMemory(context);
            RentalRepository = new RentalRepository(context);
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
