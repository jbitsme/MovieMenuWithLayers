using MovieMenuBLL.BO;
using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL.Converters
{
    class RentalConverter
    {
        internal Rental convert(RentalBO rental)
        {
            return new Rental()
            {
                Id = rental.Id,
                From = rental.From,
                To = rental.To
            };
        }

        internal RentalBO Convert(Rental rental)
        {
            return new RentalBO()
            {
                Id = rental.Id,
                From = rental.From,
                To = rental.To
            };
        }
    }
}
