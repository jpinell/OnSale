﻿using Microsoft.EntityFrameworkCore;
using OnSale.Common.Entities;

namespace OnSale.Web.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            // Haber si sirve esta mierda
        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Country>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<Department>()
                .HasIndex(t => t.Name)
                .IsUnique();

            modelBuilder.Entity<City>()
                .HasIndex(t => t.Name)
                .IsUnique();
        }
    }
}
