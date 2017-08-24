using System;
using System.Collections.Generic;
using System.Text;
using MovieMenuEntity;
using MovieMenuDAL;
using System.Linq;

namespace MovieMenuBLL.Services
{
    class MovieService : IMovieService
    {
        IMovieRepository repo;

        public MovieService(IMovieRepository repo)
        {
            this.repo = repo;
        }

        public Movie Create(Movie mov)
        {
            return repo.Create(mov);
        }

        public Movie Delete(int Id)
        {
           return  repo.Delete(Id);
        }

        public Movie Get(int Id)
        {
            return repo.Get(Id);
        }

        public IEnumerable<Movie> getAll()
        {
            return repo.getAll();
        }

        public Movie Update(Movie mov)
        {
            var movieFromDB = Get(mov.Id);
            if(movieFromDB == null)
            {
                throw new InvalidOperationException("Movie Not Found");
            }
            movieFromDB.Title = mov.Title;
            movieFromDB.Auther = mov.Auther;
            movieFromDB.Genre = mov.Genre;
            movieFromDB.Length = mov.Length;
            return movieFromDB;
        }

        public void Search(string filter)
        {
            foreach (Movie Movie in getAll())
            {
                if (Movie.Title.ToLower().Contains(filter.ToLower()))
                {
                    Console.WriteLine(($"Id: {Movie.Id} Name: {Movie.Title} Auther: {Movie.Auther} Genre: {Movie.Genre} Length: {Movie.Length}\n"));
                }
            }
        }

        public Movie get(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
