using System;
using FastFoodX.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace FastFoodX.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) { }

        public DbSet<User> Users => Set<User>();
        public DbSet<Customer> Customers => Set<Customer>();
        public DbSet<DeliveryAgent> DeliveryAgents => Set<DeliveryAgent>();
        public DbSet<Restaurant> Restaurants => Set<Restaurant>();
        public DbSet<Menu> Menus => Set<Menu>();
        public DbSet<Promotion> Promotions => Set<Promotion>();
        public DbSet<Order> Orders => Set<Order>();
        public DbSet<OrderItem> OrderItems => Set<OrderItem>();
        public DbSet<Payment> Payments => Set<Payment>();
        public DbSet<Delivery> Deliveries => Set<Delivery>();
        public DbSet<Review> Reviews => Set<Review>();
        public DbSet<Report> Reports => Set<Report>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // One-to-one relationships
            modelBuilder.Entity<Customer>()
                .HasOne(c => c.User)
                .WithOne(u => u.Customer)
                .HasForeignKey<Customer>(c => c.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DeliveryAgent>()
                .HasOne(d => d.User)
                .WithOne(u => u.DeliveryAgent)
                .HasForeignKey<DeliveryAgent>(d => d.UserID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Restaurant>()
                .HasOne(r => r.Owner)
                .WithOne(u => u.Restaurant)
                .HasForeignKey<Restaurant>(r => r.OwnerID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Payment>()
                .HasOne(p => p.Order)
                .WithOne(o => o.Payment)
                .HasForeignKey<Payment>(p => p.OrderID)
                .OnDelete(DeleteBehavior.Restrict);

            // Delivery relationships
            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Order)
                .WithOne(o => o.Delivery)
                .HasForeignKey<Delivery>(d => d.OrderID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Delivery>()
                .HasOne(d => d.Agent)
                .WithMany(a => a.Deliveries)
                .HasForeignKey(d => d.AgentID)
                .OnDelete(DeleteBehavior.Restrict);

            // Menu
            modelBuilder.Entity<Menu>()
                .HasOne(m => m.Restaurant)
                .WithMany(r => r.Menus)
                .HasForeignKey(m => m.RestaurantID)
                .OnDelete(DeleteBehavior.Restrict);

            // Orders
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(o => o.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Order>()
                .HasOne(o => o.Promotion)
                .WithMany(p => p.Orders)
                .HasForeignKey(o => o.PromoID)
                .OnDelete(DeleteBehavior.Restrict);

            // OrderItems
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Order)
                .WithMany(o => o.OrderItems)
                .HasForeignKey(oi => oi.OrderID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<OrderItem>()
                .HasOne(oi => oi.Menu)
                .WithMany(m => m.OrderItems)
                .HasForeignKey(oi => oi.MenuID)
                .OnDelete(DeleteBehavior.Restrict);

            // Reviews
            modelBuilder.Entity<Review>()
                .HasOne(rv => rv.Customer)
                .WithMany(c => c.Reviews)
                .HasForeignKey(rv => rv.CustomerID)
                .OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Review>()
                .HasOne(rv => rv.Restaurant)
                .WithMany(r => r.Reviews)
                .HasForeignKey(rv => rv.RestaurantID)
                .OnDelete(DeleteBehavior.Restrict);

            // Reports
            modelBuilder.Entity<Report>()
                .HasOne(r => r.User)
                .WithMany(u => u.Reports)
                .HasForeignKey(r => r.GeneratedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
