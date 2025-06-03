using App.Models;
using Microsoft.EntityFrameworkCore;

namespace App.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        
        }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmpId = 1, Name = "John Doe", Age = 30, DepId = 001, IdNum = 392232343},
                new Employee { EmpId = 2, Name = "John Joe", Age = 28, DepId = 002, IdNum = 392232443}
                );
        }
    }
}
