using Microsoft.EntityFrameworkCore;
using System;

namespace ContactManagerApp.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ContactManagerApp;User Id=SA;Password=Linux=Freedom716716$;TrustServerCertificate=True;Encrypt=False;",
                sqlServerOptionsAction: sqlOptions =>
                {
                    sqlOptions.EnableRetryOnFailure(
                        maxRetryCount: 5,
                        maxRetryDelay: TimeSpan.FromSeconds(10),
                        errorNumbersToAdd: null);
                });
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, Name = "Family" },
                new Category { CategoryId = 2, Name = "Friends" },
                new Category { CategoryId = 3, Name = "Work" }
            );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { 
                    ContactId = 1, 
                    Firstname = "Delores", 
                    Lastname = "Del Rio", 
                    Phone = "555-987-6543", 
                    Email = "delores@hotmail.com", 
                    CategoryId = 2, 
                    DateAdded = DateTime.ParseExact("09/27/2024 01:24 PM", "MM/dd/yyyy hh:mm tt", null) 
                },
                new Contact { 
                    ContactId = 2, 
                    Firstname = "Efren", 
                    Lastname = "Herrera", 
                    Phone = "555-456-7890", 
                    Email = "efren@aol.com", 
                    CategoryId = 3, 
                    DateAdded = DateTime.ParseExact("08/12/2024 09:30 AM", "MM/dd/yyyy hh:mm tt", null) 
                },
                new Contact { 
                    ContactId = 3, 
                    Firstname = "Mary Ellen", 
                    Lastname = "Walton", 
                    Phone = "555-123-4567", 
                    Email = "MaryEllen@yahoo.com", 
                    CategoryId = 1, 
                    DateAdded = DateTime.ParseExact("11/01/2024 02:33 PM", "MM/dd/yyyy hh:mm tt", null) 
                }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}
