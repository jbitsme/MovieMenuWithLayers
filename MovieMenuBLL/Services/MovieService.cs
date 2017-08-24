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
        public Movie Create(Movie mov)
        {
            Movie newMov;
            FakeDB.Movies.Add(newMov = new Movie()
            {
                Id = FakeDB.Id++,
                Title = mov.Title,
                Auther = mov.Auther,
                Genre = mov.Genre,
                Length = mov.Length
            });
            return newMov;
        }

        public Movie Delete(int Id)
        {
            var mov = get(Id);
            FakeDB.Movies.Remove(mov);
            return mov;
        }

        public Movie get(int Id)
        {
            return FakeDB.Movies.FirstOrDefault(x => x.Id == Id);
        }

        public IEnumerable<Movie> getAll()
        {
            return new List<Movie> (FakeDB.Movies);
        }

        public Movie Update(Movie mov)
        {
            var movieFromDB = get(mov.Id);
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
    }
}
