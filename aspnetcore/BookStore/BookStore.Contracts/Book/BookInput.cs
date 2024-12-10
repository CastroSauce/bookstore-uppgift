using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Book
{
    public class BookInput
    {
        [Required]
        public string Titel { get; set; } 

        [Required]
        public string Author { get; set; }
        [Required]
        public DateTime PublishDate { get; set; }

    }
}
