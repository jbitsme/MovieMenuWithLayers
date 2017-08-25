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
        DALFacade facade;
        public MovieService(DALFacade facade)
        {
            this.facade = facade;
        }

        public Movie Create(Movie mov)
        {
            using (var uow = facade.UniteOfWork)
            {
                var newMov = uow.MovieRepository.Create(mov);
                uow.Complete();
                return newMov;
            }
        }

        public Movie Delete(int Id)
        {
            using (var uow = facade.UniteOfWork)
            {
                var newMov = uow.MovieRepository.Delete(Id);
                uow.Complete();
                return newMov;
            }
        }

        public Movie get(int Id)
        {
            using (var uow = facade.UniteOfWork)
            {
                return uow.MovieRepository.Get(Id);
            }
        }

        public IEnumerable<Movie> getAll()
        {
            using (var uow = facade.UniteOfWork)
            {
                return uow.MovieRepository.getAll();
            }
        }

        public Movie Update(Movie mov)
        {
            using (var uow = facade.UniteOfWork)
            {
                var movieFromDB = uow.MovieRepository.Get(mov.Id);
                if (movieFromDB == null)
                {
                    throw new InvalidOperationException("Movie Not Found");
                }
                movieFromDB.Title = mov.Title;
                movieFromDB.Auther = mov.Auther;
                movieFromDB.Genre = mov.Genre;
                movieFromDB.Length = mov.Length;
                uow.Complete();
                return movieFromDB;
            }
            
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
