using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace DiaryApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "contemplating life",
                    Content = "contemplating life with my Deus Imperator PHG",
                    Created = new DateTime(2024, 9, 16) // Data específica
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "contemplating the moon",
                    Content = "contemplating the moon with my Deus Imperator PHG",
                    Created = new DateTime(2024, 9, 16) // Data específica
                },
                new DiaryEntry
                {
                    Id = 3,
                    Title = "contemplating the sun",
                    Content = "contemplating the sun with my Deus Imperator PHG",
                    Created = new DateTime(2024, 9, 16) // Data específica
                }
            );
        }
    }
}


// 1. Create a model class
// 2. Add DbSet
// 3. add-migration
// 4. update-database