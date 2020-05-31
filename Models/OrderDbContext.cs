using Microsoft.EntityFrameworkCore;

namespace _91APP_Interview.Models
{
    public class OrderDbContext : DbContext
    {
        public OrderDbContext(DbContextOptions<OrderDbContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>()
                .HasData(
                    new Product() { Id = "P001", Name = "Product1", Description = "This is Product1"},
                    new Product() { Id = "P002", Name = "Product2", Description = "This is Product2"},
                    new Product() { Id = "P003", Name = "Product3", Description = "This is Product3"},
                    new Product() { Id = "P004", Name = "Product4", Description = "This is Product4"}
                );

            modelBuilder.Entity<Order>()
                .HasData(
                    new Order() { Id = "A20202026001", ProductId = "P001", Price = 100, Cost = 90, Status = "Payment completed" },
                    new Order() { Id = "A20202023001", ProductId = "P002", Price = 120, Cost = 100, Status = "Payment completed" },
                    new Order() { Id = "A20202026002", ProductId = "P003", Price = 200, Cost = 150, Status = "Payment completed" },
                    new Order() { Id = "A20202024003", ProductId = "P004", Price = 150, Cost = 120, Status = "Payment completed" }
                );
        }
    }
}
