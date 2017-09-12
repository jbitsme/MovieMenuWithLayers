using MovieMenuBLL.BO;
using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL.Converters
{
    class MovieConverter
    {
        internal Movie convert(MovieBO mov)
        {
            return new Movie()
            {
                Id = mov.Id,
                Title = mov.Title,
                Auther = mov.Auther,
                Length = mov.Length,
                Genre = mov.Genre
            };
        }

        private MovieBO Convert(Movie mov)
        {
            return new MovieBO()
            {
                Id = mov.Id,
                Title = mov.Title,
                Auther = mov.Auther,
                Length = mov.Length,
                Genre = mov.Genre
            };
        }
    }
}
