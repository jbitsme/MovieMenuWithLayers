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

        public IRentalService RentalService
        {
            get { return new RentalService(new DALFacade()); }
        }
    }
}
