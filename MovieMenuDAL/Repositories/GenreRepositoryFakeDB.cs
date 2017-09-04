using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MovieMenuDAL.Repositories
{
    class GenreRepositoryFakeDB : IGenreRepository
    {
        private static int Id = 1;
        private static List<Genre> Movies = new List<Genre>();

        public Genre Get(int Id)
        {
            return Movies.FirstOrDefault(x => x.Id == Id);
        }
    }
}
