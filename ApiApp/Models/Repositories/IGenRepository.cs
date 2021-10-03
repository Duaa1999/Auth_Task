using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models.Repositories
{
    public interface IGenRepository <T> where T : class
    {
        Task<T> Get(int id);
        Task<List<T>> GetAll();
        Task Add(T entity);
    }

}
