using MovieMenuDAL.Repositories;
using MovieMenuDAL.UOW;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL
{
    public class DALFacade
    {
        public IMovieRepository MovieRepository
        {
            get
            {
                return new MovieRepositoryEFMemory(new Context.InMemoryContext());
            }
        }
        public IUnitOfWork UniteOfWork
        {
            get
            {
                return new UnitOfWorkMem();
            }
        }
    }
}
