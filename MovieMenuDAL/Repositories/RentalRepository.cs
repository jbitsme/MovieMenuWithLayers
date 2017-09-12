using System;
using System.Collections.Generic;
using System.Text;
using MovieMenuDAL.Entities;
using MovieMenuDAL.Context;
using System.Linq;

namespace MovieMenuDAL.Repositories
{
    class RentalRepository : IRentalRepository
    {
        MovieContext _context;

        public RentalRepository(MovieContext context)
        {
            _context = context;
        }
        
        public Rental Create(Rental rental)
        {
            _context.Rentals.Add(rental);
            return rental;
        }

        public Rental Delete(int Id)
        {
            var rental = Get(Id);
            _context.Rentals.Remove(rental);
            return rental;
        }

        public Rental Get(int Id)
        {
            return _context.Rentals.FirstOrDefault(r => r.Id == Id);
        }

        public IEnumerable<Rental> getAll()
        {
            return _context.Rentals.ToList();
        }

        public void Search(string filter)
        {
            throw new NotImplementedException();
        }
    }
}
