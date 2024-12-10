using BookStore.Book;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers.Book
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase, IBookApplicationService
    {
        readonly IBookApplicationService _BookApplicationService;
        public BookController(IBookApplicationService bookApplicationService)
        {
            _BookApplicationService = bookApplicationService;
        }

        [HttpDelete]
        [Route("{id}")]
        public Task<Guid> DeleteBook(Guid id)
        {
            return _BookApplicationService.DeleteBook(id);
        }

        [HttpGet]
  
        public Task<List<BookDto>> GetBooks()
        {
            return _BookApplicationService.GetBooks();
        }

        [HttpPost]
        public Task<BookDto> PostBook(BookInput input)
        {
            return _BookApplicationService.PostBook(input);
        }
    }
}
