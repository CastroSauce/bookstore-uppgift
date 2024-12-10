using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public class BookManager
    {
        public BookManager()
        {
        }

        public  BookEntity CreateBook(string titel, string author, DateTime publishDate)
        {
            var entity = new BookEntity(titel, author, publishDate);
            
            return entity;
        }

    
    }
}
