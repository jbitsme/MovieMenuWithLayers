using System;
using System.Collections.Generic;
using MovieMenuDAL;
using System.Linq;
using MovieMenuBLL.BO;
using MovieMenuDAL.Entities;
using MovieMenuBLL.Converters;

namespace MovieMenuBLL.Services
{
    class MovieService : IMovieService
    {
        MovieConverter conv = new MovieConverter();
        DALFacade facade;
        public MovieService(DALFacade facade)
        {
            this.facade = facade;
        }

        public MovieBO Create(MovieBO mov)
        {
            using (var uow = facade.UniteOfWork)
            {
                var newMov = uow.MovieRepository.Create(conv.convert(mov));
                uow.Complete();
                return conv.convert(newMov);
            }
        }

        public MovieBO Delete(int Id)
        {
            using (var uow = facade.UniteOfWork)
            {
                var newMov = uow.MovieRepository.Delete(Id);
                uow.Complete();
                return conv.convert(newMov);
            }
        }

        public MovieBO get(int Id)
        {
            using (var uow = facade.UniteOfWork)
            {
                return conv.convert(uow.MovieRepository.Get(Id));
            }
        }

        public IEnumerable<MovieBO> getAll()
        {
            using (var uow = facade.UniteOfWork)
            {
                return uow.MovieRepository.getAll().Select(m => conv.convert(m)).ToList();
            }
        }

        public MovieBO Update(MovieBO mov)
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
                return conv.convert(movieFromDB);
            }
            
        }

        public void Search(string filter)
        {
            foreach (MovieBO Movie in getAll())
            {
                if (Movie.Title.ToLower().Contains(filter.ToLower()))
                {
                    Console.WriteLine(($"Id: {Movie.Id} Name: {Movie.Title} Auther: {Movie.Auther} Genre: {Movie.Genre} Length: {Movie.Length}\n"));
                }
            }
        }
    }
}
