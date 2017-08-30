using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using MovieMenuDAL.Entities;

namespace MovieMenuDAL.Repositories
{
    class MovieRepositoryFakeDB : IMovieRepository
    {
        private static int Id = 1;
        private static List<Movie> Movies = new List<Movie>();

        public Movie Create(Movie mov)
        {
            {
                Movie newMov;
                Movies.Add(newMov = new Movie()
                {
                    Id = Id++,
                    Title = mov.Title,
                    Auther = mov.Auther,
                    Genre = mov.Genre,
                    Length = mov.Length
                });
                return newMov;
            }
        }

        public Movie Delete(int Id)
        {
            var mov = Get(Id);
            Movies.Remove(mov);
            return mov;
        }

        public Movie Get(int Id)
        {
            return Movies.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Movie> getAll()
        {
            return new List<Movie>(Movies);
        }

        public void Search(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
