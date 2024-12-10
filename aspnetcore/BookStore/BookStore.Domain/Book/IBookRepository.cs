using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public interface IBookRepository
    {
        public Task<BookEntity> GetAsync();
    }
}
