using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductStore_DataAccessLayer.Interfaces
{
    public interface IUserRepository
    {
        Task<User> isUserExist(string UserName, string Password);

    }
}
