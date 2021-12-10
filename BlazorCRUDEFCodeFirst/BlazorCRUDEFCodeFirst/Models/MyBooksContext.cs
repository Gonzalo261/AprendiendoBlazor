using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEFCodeFirst.Models
{
    public class MyBooksContext :  DbContext
    {
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-CQUI9AH\\SQLEXPRESS;Initial Catalog=BlazorCRUDEFCodeFirst;Persist Security Info=True;User ID=sa;Password=sa");
        }
    }
}
