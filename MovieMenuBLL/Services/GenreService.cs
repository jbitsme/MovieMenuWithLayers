using MovieMenuBLL.BO;
using MovieMenuDAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL.Services
{
    class GenreService : IGenreService
    {
        DALFacade facade;
        public GenreService(DALFacade facade)
        {
            this.facade = facade;
        }

        public GenreBO Get(int Id)
        {
            using (var uow = facade.UniteOfWork)
            {
                return uow.GenreRepository.Get(Id);
            }
        }
    }
}
