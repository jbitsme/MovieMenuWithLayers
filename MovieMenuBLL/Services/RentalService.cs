using System;
using System.Collections.Generic;
using System.Text;
using MovieMenuBLL.BO;
using MovieMenuDAL;
using MovieMenuBLL.Converters;
using System.Linq;

namespace MovieMenuBLL.Services
{
    class RentalService : IRentalService
    {
        RentalConverter conv = new RentalConverter();
        private DALFacade _facade;

        public RentalService(DALFacade facade)
        {
            _facade = facade;
        }

        public RentalBO Create(RentalBO rental)
        {
            using (var uow = _facade.UniteOfWork)
            {
                var rentalEntity = uow.RentalRepository.Create(conv.convert(rental));
                uow.Complete();
                return conv.convert(rentalEntity);
            }
        }

        public RentalBO Delete(int Id)
        {
            using (var uow = _facade.UniteOfWork)
            {
                var rentalEntity = uow.RentalRepository.Delete(Id);
                uow.Complete();
                return conv.convert(rentalEntity);
            }
        }

        public RentalBO get(int Id)
        {
            using (var uow = _facade.UniteOfWork)
            {
                var rentalEntity = uow.RentalRepository.Get(Id);
                return conv.convert(rentalEntity);
            }
        }

        public IEnumerable<RentalBO> getAll()
        {
            using (var uow = _facade.UniteOfWork)
            {
                return uow.RentalRepository.getAll().Select(conv.convert).ToList();
            }
        }

        public void Search(string filter)
        {
            throw new NotImplementedException();
        }

        public RentalBO Update(RentalBO rental)
        {
            using (var uow = _facade.UniteOfWork)
            {
                var rentalEntity = uow.RentalRepository.Get(rental.Id);
                if(rentalEntity == null)
                {
                    throw new InvalidOperationException("rental not found");
                }
                rentalEntity.From = rentalEntity.From;
                rentalEntity.To = rentalEntity.To;
                uow.Complete();
                return conv.convert(rentalEntity);
            }
        }
    }
}
