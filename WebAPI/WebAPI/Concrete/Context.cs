using System;
using Microsoft.EntityFrameworkCore;
using WebAPI.Entity;

namespace WebAPI.Concrete
{
	public class Context : DbContext
	{
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost,5432;Database=SchoolDatabase;Username=myuser;Password=mypassword;TrustServerCertificate=True;");
        }
        public DbSet<Lesson> Lessons { get; set; }
    }
}

