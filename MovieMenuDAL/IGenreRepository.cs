using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL
{
    interface IGenreRepository
    {
        Genre Get(int Id);
    }
}
