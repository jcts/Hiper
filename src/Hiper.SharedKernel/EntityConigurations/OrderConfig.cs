using Hiper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiper.SharedKernel.EntityConigurations
{
    public sealed class OrderConfig : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            _ = builder.ToTable("Orders")
                .HasKey(c => c.Id);
            
            _ = builder.HasOne(c => c.Customer)
                .WithMany(c => c.Orders)
                .HasForeignKey(c => c.CustomerId);
        }
    }
}