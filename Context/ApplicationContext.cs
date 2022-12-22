using WPFDB.Models;
using Microsoft.EntityFrameworkCore;

namespace WPFDB.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        public ApplicationContext() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=BALYSHEV-PC\\SQLEXPRESS;Database=Employees;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}