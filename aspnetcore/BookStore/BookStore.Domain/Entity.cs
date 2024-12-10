using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
    }
}
