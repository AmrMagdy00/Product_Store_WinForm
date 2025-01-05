using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_BussinessLayer.Dtos;
using ProductStore_DataAccessLayer;

namespace ProductStore_BussinessLayer.Mapper
{
    public static class UserMapper
    {
        public static UserDTO ToDto (this User user)
        {
            UserDTO DTO = new UserDTO ();
            DTO.UserName = user.UserName;
            DTO.Email = user.Email;
            DTO.Id = user.Id;
            DTO.Role = user.Role.RoleName;

            return DTO;

        }

    }
}
