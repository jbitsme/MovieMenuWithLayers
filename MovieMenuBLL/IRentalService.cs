using MovieMenuBLL.BO;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL
{
    public interface IRentalService
    {
        //Create movie
        RentalBO Create(RentalBO rental);
        //Read
        IEnumerable<RentalBO> getAll();
        void Search(string filter);
        RentalBO get(int Id);
        //Edit
        RentalBO Update(RentalBO rental);
        //Delete
        RentalBO Delete(int Id);
    }
}
