using ApiApp.Models.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models
{
    public static class Service
    {
        public static void AddService(this IServiceCollection serv , IConfiguration strCon)
        {
            serv.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApplication", Version = "v1" });
            });
            serv.AddDbContext<AppDbContext>(option =>
            {
                option.UseSqlServer(strCon.GetConnectionString("SqlCon"));
            });
            serv.AddScoped<IUserRepo, UserService>();
            serv.AddScoped<IPostRepo, PostService>();
            serv.AddControllers();
            serv.AddAutoMapper(typeof(Startup));


        }
    }
}
