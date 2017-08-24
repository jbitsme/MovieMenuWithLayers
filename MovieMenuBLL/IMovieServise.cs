using MovieMenuEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL
{
    public interface IMovieService
    {
        //Create movie
        Movie Create(Movie mov);
        //Read
        IEnumerable<Movie> getAll();
        void Search(string filter);
        Movie get(int Id);
        //Edit
        Movie Update(Movie mov);
        //Delete
        Movie Delete(int Id);
    }
}
