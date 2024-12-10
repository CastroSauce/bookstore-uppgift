using BookStore.Book;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Efcore.Context
{
    public class BookStoreContext : DbContext
    {

        public DbSet<BookEntity> Books { get; set; }


        public BookStoreContext(DbContextOptions<BookStoreContext> options)
         : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Set to autogenerate an id for the entity if none is provided
            modelBuilder.Entity<BookEntity>()
               .Property(t => t.Id)
               .ValueGeneratedOnAdd();
        }

    }
}
