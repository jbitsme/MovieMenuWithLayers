using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuDAL
{
    public interface IRentalRepository
    {
        //Create a rental
        Rental Create(Rental ren);
        //Read
        IEnumerable<Rental> getAll();
        void Search(string filter);
        Rental Get(int Id);
        //Delete
        Rental Delete(int Id);
    }
}
