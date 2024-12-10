using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public class BookApplicationService : IBookApplicationService
    {
        readonly BookManager _BookManager;
        readonly IRepository<BookEntity> _BookRepository;

        public BookApplicationService(BookManager bookManager, IRepository<BookEntity> bookRepository)
        {
            _BookManager = bookManager;
            _BookRepository = bookRepository;
        }

        public async Task<Guid> DeleteBook(Guid id)
        {
           await _BookRepository.Delete(id);

           return id;
        }

        public async Task<List<BookDto>> GetBooks()
        {
            var book = await _BookRepository.GetList();

            return book.Select(x =>
                new BookDto { Id = x.Id, Author = x.Author, Titel = x.Titel, PublishDate = x.PublishDate }
            ).ToList();
         }


        public async Task<BookDto> PostBook(BookInput input)
        {
            var book =  _BookManager.CreateBook(input.Titel, input.Author, input.PublishDate);

            await _BookRepository.Insert(book);

            return new BookDto { Id = book.Id, Author = book.Author, Titel = book.Titel, PublishDate = book.PublishDate };
        }
    }
}
