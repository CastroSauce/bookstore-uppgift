using BookStore.Efcore.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Efcore
{
    /// <summary>
    /// Generic repository implementation for basic entity crud operations
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Repository<T> : IRepository<T> where T : Entity
    {
        readonly DbContext _DBContext;

        public Repository(BookStoreContext bookStoreContext)
        {
            _DBContext = bookStoreContext;
        }

        public async Task Delete(Guid id)
        {
           await _DBContext.Set<T>().Where(x => x.Id.Equals(id)).ExecuteDeleteAsync();
        }

        public async Task<T> Get(Guid id)
        {
           return await _DBContext.Set<T>().Where(x => x.Id.Equals(id)).FirstAsync();
        }

        public async Task<List<T>> GetList()
        {
            return await _DBContext.Set<T>().ToListAsync();
        }

        public async Task Insert(T insert)
        {
            await _DBContext.Set<T>().AddAsync(insert);
            await _DBContext.SaveChangesAsync();
      

        }
    }
}
