using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_BussinessLayer.Mapper;
using ProductStore_DataAccessLayer;
using ProductStore_DataAccessLayer.Interfaces;
using ProductStore_DataAccessLayer.Repository;

namespace ProductStore_BussinessLayer.Users
{
    public class UserService : IUserService
    {
        private  readonly IUserRepository _repository;
        public UserService(IUserRepository Repository) 
        {
            _repository = Repository;
        }

        public async Task<UserDTO> isUserExist(string UserName ,string Password)
        {
            User user =  await _repository.isUserExist(UserName, Password);
            if (user == null)
            {
                return null;
            }
            return user.ToDto();
        }

    }
}
