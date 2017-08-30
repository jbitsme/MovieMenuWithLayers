using MovieMenuBLL.BO;
using System.Collections.Generic;

namespace MovieMenuBLL
{
    public interface IMovieService
    {
        //Create movie
        MovieBO Create(MovieBO mov);
        //Read
        IEnumerable<MovieBO> getAll();
        void Search(string filter);
        MovieBO get(int Id);
        //Edit
        MovieBO Update(MovieBO mov);
        //Delete
        MovieBO Delete(int Id);
    }
}
