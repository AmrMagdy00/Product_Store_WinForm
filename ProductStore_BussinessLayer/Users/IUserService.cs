using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;

namespace ProductStore_BussinessLayer.Users
{
    public interface IUserService
    {
        Task<UserDTO> isUserExist(string UserName, string Password);

    }
}
