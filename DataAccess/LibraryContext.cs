﻿using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Text;
using IDataInterface;

namespace DataAccess
{
    public class LibraryContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=MSI;Database=Library;Trusted_connection=true");
        }
        public DbSet<Aisle> Ailes { get; set; }
        public DbSet<Shelf> Shelves { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Lending> Lendings { get; set; }
        public DbSet<TimeSlot> TimeSlots { get; set; }
        public DbSet<Debt> Debts { get; set; }
    }
}
