using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models.Repositories
{

    public class PostService : GenRepository<Post>, IPostRepo
    {
        private readonly AppDbContext context;
        public PostService(AppDbContext context) : base(context)
        {
            context = context;
        }
        public List<Post> GetMyPosts()
        {
            return context.Post.ToList();
        }
    }
}
