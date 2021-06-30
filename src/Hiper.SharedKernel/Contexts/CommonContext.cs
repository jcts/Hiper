using Hiper.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Hiper.SharedKernel.Contexts
{
    public sealed class CommonContext : DbContext
    {
        public DbSet<Customer> Orders { get; set; }

        public CommonContext(DbContextOptions<CommonContext> options) : base(options)
        { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>();

            base.OnModelCreating(modelBuilder);
        }

    }
}
