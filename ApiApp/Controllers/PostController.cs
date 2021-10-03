using ApiApp.Models;
using ApiApp.Models.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PostController : Controller
    {
        private readonly IPostRepo postRepo;
        public PostController(IPostRepo postRepo)
        {
            this.postRepo = postRepo;
        }

        [HttpGet("{id}")]
        public async Task<Post> getPost(int id)
        {
            return await postRepo.Get(id);
        }

        [HttpGet]
        public async Task<List<Post>> getAllPost()
        {
            return (await postRepo.GetAll());
        }

        [HttpPost]
        public async Task addPost([FromBody] Post p)
        {
             await postRepo.Add(p);
        }
     
    }
}
