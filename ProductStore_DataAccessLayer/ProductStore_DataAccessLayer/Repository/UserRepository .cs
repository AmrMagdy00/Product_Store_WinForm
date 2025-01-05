using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductStore_DataAccessLayer.Interfaces;

namespace ProductStore_DataAccessLayer.Repository
{
    public class UserRepository  : IUserRepository
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<User> isUserExist(string UserName , string Password)
        {

            return await _context.Users
                       .AsNoTracking() 
                    .Include(u => u.Role) 
                   .FirstOrDefaultAsync(x => x.UserName == UserName && x.Password == Password);
        }

    }
}
