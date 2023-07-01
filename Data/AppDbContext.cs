using FluentAssertions;
using HRMS.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HRMS.Data
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Item_Dish>().HasKey(am => new
            {
                am.ItemId,
                am.DishId
            });

            modelBuilder.Entity<Item_Dish>().HasOne(m => m.Dish).WithMany(am => am.Items_Dishes).HasForeignKey(m => m.DishId);
            modelBuilder.Entity<Item_Dish>().HasOne(m => m.Item).WithMany(am => am.Items_Dishes).HasForeignKey(m => m.ItemId);
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Item> Items { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Item_Dish> Items_Dishes { get; set; }

        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<ShoppingCartItem> ShoppingCartItems { get; set; }

    }
}
