using Microsoft.EntityFrameworkCore;
using DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider
{
    public class P1DbContext : DbContext
    {

        public DbSet<ToDoItem> ToDoItems { get; set; }

        public P1DbContext(DbContextOptions<P1DbContext> options) : base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Server=localhost;Database=master;Trusted_Connection=True;");
        //}

    }
}
