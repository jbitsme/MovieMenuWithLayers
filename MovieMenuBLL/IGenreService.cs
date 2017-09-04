using MovieMenuBLL.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL
{
    public interface IGenreService
    {
        GenreBO Get(int Id);
    }
}
