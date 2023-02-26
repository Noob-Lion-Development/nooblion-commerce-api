using Microsoft.EntityFrameworkCore;
using nooblion_commerce_api.Models;

namespace nooblion_commerce_api.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) 
        { 
        
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=Nooblion-Commerce-Local;Trusted_Connection=True;TrustServerCertificate=true;MultipleActiveResultSets=True");
        }
        //DbSet<MODEL> fields are checked by entity framework and each represent their own respective table within the database
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
    }
}
