using Hiper.Domain.Entities;
using Hiper.SharedKernel.EntityConigurations;
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
            modelBuilder.ApplyConfiguration(new ProductConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}
