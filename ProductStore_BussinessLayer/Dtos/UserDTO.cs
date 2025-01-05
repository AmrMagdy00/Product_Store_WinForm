using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_DataAccessLayer;

namespace ProductStore_BussinessLayer.Dtos
{
    public class UserDTO
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }

    }
}
