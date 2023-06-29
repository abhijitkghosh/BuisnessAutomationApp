﻿using BuisnessAutomation.Models.EntityModels;
using BusinessAutomations.Models.EntityModels;
using Microsoft.EntityFrameworkCore;

namespace BuisnessAutomation.Database
{
    public class BusinessAutomationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Brand> Brands { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
            string connectionString = "Server=(local);Database=BusinessAutomationDB;Trusted_Connection=True;TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
            base.OnConfiguring(optionsBuilder);
        }
    }
}
