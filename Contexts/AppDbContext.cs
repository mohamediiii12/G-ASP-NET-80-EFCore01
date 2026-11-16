using System;
using System.Collections.Generic;
using System.Text;
using G_ASP_NET_80_EFCore01.Models;
using Microsoft.EntityFrameworkCore;

namespace G_ASP_NET_80_EFCore01.Contexts
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-V14FACA;Database=BOOKSTORE;trusted_connection=true ; trustServerCertificate=true;");
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Author> authors { get; set; }
        public DbSet<Category> categories { get; set; }

    }
}
