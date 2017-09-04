using MovieMenuDAL.Context;
using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieMenuDAL.Repositories
{
    class GenreRepositoryEFMemory : IGenreRepository
    {
        InMemoryContext _context;

        public  GenreRepositoryEFMemory(InMemoryContext context)
        {
            _context = context;
        }

        public Genre Get(int Id)
        {
            return _context.Genres.FirstOrDefault(g => g.Id == Id);
        }
    }
}
