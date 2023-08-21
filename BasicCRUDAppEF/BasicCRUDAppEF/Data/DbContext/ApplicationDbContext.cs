using System;
using Microsoft.EntityFrameworkCore;

namespace BasicCRUDAppEF
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5433;Database=postgres;Username=postgres;Password=postgres;");
        }

    }

}

