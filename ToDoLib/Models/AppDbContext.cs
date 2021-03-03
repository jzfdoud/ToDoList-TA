using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoLib.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<ToDo> ToDos { get; set; }
        public DbSet<Category> Categories { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                var connStr = "server=localhost\\sqlexpress;" +
                                "database=ToDoListTA;" +
                                "trusted_connection=true;";
                builder.UseSqlServer(connStr);
            }
        }

        public AppDbContext() { }
    }
}
