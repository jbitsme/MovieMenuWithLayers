using MovieMenuBLL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL
{
    public class BLLFacade
    {
        public IMovieService GetMovieService()
        {
            return new MovieService();
        }

        public IMovieService MovieService
        {
            get { return new MovieService(); }
        }
    }
}
