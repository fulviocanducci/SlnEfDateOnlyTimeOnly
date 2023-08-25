using Microsoft.EntityFrameworkCore;
using Models.Mappings;
using System;

namespace Models
{
   public class DatabaseAccess : DbContext
   {
      public DbSet<People> People { get; set; }
      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         modelBuilder.ApplyConfiguration(new PeopleMapping());
      }
      protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         optionsBuilder.UseMySql("server=localhost;user=root;password=senha;database=super", new MySqlServerVersion(new Version(8, 0, 31)));
      }
   }
}
