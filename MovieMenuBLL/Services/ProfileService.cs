using MovieMenuBLL.BO;
using MovieMenuDAL;
using MovieMenuDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MovieMenuBLL.Services
{
    class ProfileService : IProfileService
    {
        DALFacade facade;
        public ProfileService(DALFacade facade)
        {
            this.facade = facade;
        }

        public ProfileBO Create(ProfileBO pro)
        {
            using (var uow = facade.UniteOfWork)
            {
                var newPro = uow.MovieRepository.Create(Convert(pro));
                uow.Complete();
                return Convert(newPro);
            }
        }

        public ProfileBO Get(int Id)
        {
            using (var uow = facade.UniteOfWork)
            {
                return uow.GenreRepository.Get(Id);
            }
        }

        private Profile Convert(ProfileBO pro)
        {
            return new Profile()
            {
                Id = pro.Id,
                FirstName = pro.FirstName,
                LastName = pro.LastName,
                Address = pro.Address,
                Email = pro.Email,
                PhoneNr = pro.PhoneNr
            };
        }

        private ProfileBO Convert(Profile pro)
        {
            return new ProfileBO()
            {
                Id = pro.Id,
                FirstName = pro.FirstName,
                LastName = pro.LastName,
                Address = pro.Address,
                Email = pro.Email,
                PhoneNr = pro.PhoneNr
            };
        }
    }
}
