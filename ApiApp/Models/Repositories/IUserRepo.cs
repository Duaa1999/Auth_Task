using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models.Repositories
{
    public interface IUserRepo : IGenRepository<User>
    {
        public User GetWithPosts();
    }
    
}
