using System;
using System.Collections.Generic;
using System.Text;
using MovieMenuDAL.Context;
using System.Linq;
using MovieMenuDAL.Entities;

namespace MovieMenuDAL.Repositories
{
    class MovieRepositoryEFMemory : IMovieRepository
    {
        InMemoryContext _context;

        public  MovieRepositoryEFMemory(InMemoryContext context)
        {
            _context = context;
        }
        public Movie Create(Movie mov)
        {
            _context.Movies.Add(mov);
            return mov;
        }

        public Movie Delete(int Id)
        {
            var mov = Get(Id);
            _context.Movies.Remove(mov);
           return mov;
        }

        public Movie Get(int Id)
        {
            return _context.Movies.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Movie> getAll()
        {
            return _context.Movies.ToList();
        }

        public void Search(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
