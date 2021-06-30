using Hiper.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hiper.SharedKernel.Contexts
{
    public sealed class OrderContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
