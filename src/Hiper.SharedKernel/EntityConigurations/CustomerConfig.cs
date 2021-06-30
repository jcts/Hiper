using Hiper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiper.SharedKernel.EntityConigurations
{
    public sealed class CustomerConfig : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {
            _ = builder.ToTable("Customers");
            _ = builder.HasKey(c => c.Id);
            _ = builder.OwnsOne(c => c.Address);
            _ = builder.OwnsOne(c => c.Phone);
            _ = builder.HasMany(c => c.Orders)
                .WithOne(c => c.Customer);
        }
    }
}
