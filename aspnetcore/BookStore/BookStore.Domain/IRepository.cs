using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public interface IRepository<T> where T : Entity
    {
        Task<T> Get(Guid id);
        Task<List<T>> GetList();
        Task Insert(T insert);
        Task Delete(Guid id);
    }
}
