using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public interface IBookApplicationService
    {
        public Task<List<BookDto>> GetBooks();

        public Task<BookDto> PostBook(BookInput input);
        public Task<Guid> DeleteBook(Guid id);
    }
}
