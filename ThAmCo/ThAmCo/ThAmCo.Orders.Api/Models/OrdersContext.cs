using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ThAmCo.Orders.Api.Models
{
    public class OrdersContext : DbContext
    {
        public OrdersContext(DbContextOptions<OrdersContext> options) : base(options) { }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, CustomerId = 1 },
                new Order { OrderId = 2, CustomerId = 1 },
                new Order { OrderId = 3, CustomerId = 3 }
            );

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Title = "Test Product 1", Price = 9.99, OrderId = 1 },
                new Product { ProductId = 2, Title = "Test Product 1", Price = 9.99, OrderId = 2 },
                new Product { ProductId = 3, Title = "Test Product 2", Price = 4.99, OrderId = 2 },
                new Product { ProductId = 4, Title = "Test Product 3", Price = 2.99, OrderId = 3 },
                new Product { ProductId = 5, Title = "Test Product 4", Price = 3.99, OrderId = 3 },
                new Product { ProductId = 6, Title = "Test Product 5", Price = 4.50, OrderId = 3 }
            );
        }
    }
}
