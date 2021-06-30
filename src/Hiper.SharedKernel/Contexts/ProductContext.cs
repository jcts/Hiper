using Hiper.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hiper.SharedKernel.Contexts
{
    public sealed class ProductContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ProductContext(DbContextOptions<ProductContext> options) : base(options)
        {   }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>();

            base.OnModelCreating(modelBuilder);
        }
    }
}
