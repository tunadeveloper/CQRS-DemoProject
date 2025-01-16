using CQRS_DemoProject.Entities;
using Microsoft.EntityFrameworkCore;
namespace CQRS_DemoProject.Context
{
    public class CQRSContext:DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUNA\\SQLEXPRESS;initial catalog=DbCQRSDemo;integrated security=true");
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }
}
