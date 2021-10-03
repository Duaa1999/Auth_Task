using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models.Repositories
{
    class UserService : GenRepository<User>, IUserRepo
    {
        private readonly AppDbContext _context;
        public UserService(AppDbContext _context) : base(_context)
        {
            _context = _context;
        }

        public User GetWithPosts()
        {
            return _context.User.Include(c => c.Posts).FirstOrDefault();
        }
    }
}
