using MovieMenuEntity;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL
{
    public interface IMovieRepository
    {
        //Create movie
        Movie Create(Movie mov);
        //Read
        IEnumerable<Movie> getAll();
        void Search(string filter);
        Movie Get(int Id);
        //Delete
        Movie Delete(int Id);
    }
}
