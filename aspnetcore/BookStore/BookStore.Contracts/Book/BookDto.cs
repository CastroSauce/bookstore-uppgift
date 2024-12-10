using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public class BookDto
    {
        public Guid Id { get; set; }

        public string Titel { get; set; } 

        public string Author { get; set; } 

        public DateTime PublishDate { get; set; }
    }
}
