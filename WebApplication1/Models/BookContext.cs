using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Books { get; set; }



        public BookContext(DbContextOptions<BookContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=BookDB;Integrated Security=True;");
        }

        public DbSet<WebApplication1.Models.Verlag> Verlag { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Book>(entry =>
        //    {
        //        entry.Property(e => e.Id).HasColumnName("Id");
        //    });
        //}



    }
}

