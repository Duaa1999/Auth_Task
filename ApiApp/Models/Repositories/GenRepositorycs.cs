using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiApp.Models.Repositories
{

    public class GenRepository<T> : IGenRepository<T> where T : class, IModelBase
    {
        private readonly AppDbContext _context;

        public GenRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task<T> Get(int id)
        {
            T t = await _context.Set<T>().FirstOrDefaultAsync(obj => obj.Id == id);
            return t;
        }

        public async Task<List<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();

        }


    }
}
