﻿
using Microsoft.EntityFrameworkCore;
using Mvc.Models.Entity;

namespace Mvc.Models.Context
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAB11-OGRETMEN\\SQLEXPRESS;" +
                "database=csharp215;Trusted_connection=true");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Auth> Auth { get; set; }

    }
}
