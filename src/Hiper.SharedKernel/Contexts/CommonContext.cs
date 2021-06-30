using Hiper.Domain.Entities;
using Hiper.SharedKernel.EntityConigurations;
using Microsoft.EntityFrameworkCore;

namespace Hiper.SharedKernel.Contexts
{
    public sealed class CommonContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public CommonContext(DbContextOptions<CommonContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerConfig());
            base.OnModelCreating(modelBuilder);
        }

    }
}
