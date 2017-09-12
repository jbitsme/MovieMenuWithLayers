using MovieMenuDAL.Repositories;
using MovieMenuDAL.UOW;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL
{
    public class DALFacade
    {
        public IUnitOfWork UniteOfWork
        {
            get
            {
                return new UnitOfWork();
            }
        }
    }
}
