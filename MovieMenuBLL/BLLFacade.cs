using MovieMenuBLL.Services;
using MovieMenuDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL
{
    public class BLLFacade
    {
        public IMovieService MovieService
        {
            get { return new MovieService(new DALFacade()); }
        }

        public IGenreService GenreService
        {
            get { return new GenreService(new DALFacade()); }
        }
    }
}
