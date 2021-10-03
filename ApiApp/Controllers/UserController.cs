using ApiApp.Models;
using ApiApp.Models.Repositories;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        //we used inerface to apply the concept of depency enjection !!!
        private readonly IUserRepo userRepo;
        private readonly IMapper _mapper;

        public UserController(IUserRepo userRepo,IMapper mapper)
        {
            this.userRepo = userRepo;
            _mapper = mapper;
        }
       
        [HttpGet]
        public async Task<List<UserViewModel>> getAll()
        {
            return _mapper.Map<List<UserViewModel>>(await userRepo.GetAll());
        }


        [HttpGet("{id}")]
        public async Task<User> get(int id)
        {
            User u = await userRepo.Get(id);
            return u;
            
        }


        //create
        [HttpPost]
        public async Task addUser([FromBody] User u)
        {
            await userRepo.Add(u);

        }

    }
}
