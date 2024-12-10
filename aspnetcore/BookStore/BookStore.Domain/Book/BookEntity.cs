using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public class BookEntity : Entity
    {
        public string Titel { get; init; } 

        public string Author { get; init; }

        public DateTime PublishDate { get; init; }

        public BookEntity( string titel, string author, DateTime publishDate)
        {

            if (string.IsNullOrWhiteSpace(titel)) throw new ArgumentException("Book must include a title");
            if (string.IsNullOrWhiteSpace(author)) throw new ArgumentException("Book must include an author");

            Titel = titel;
            Author = author;
            PublishDate = publishDate;
        }


    }
}
