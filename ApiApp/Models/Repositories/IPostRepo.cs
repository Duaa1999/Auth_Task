using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models.Repositories
{
    public interface IPostRepo : IGenRepository<Post>
    {
        public List<Post> GetMyPosts();
    }

 
}

