using Hiper.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hiper.SharedKernel.EntityConigurations
{
    public sealed class ProductConfig : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            _ = builder.ToTable("Products")
                .HasKey(c => c.Id);
        }
    }
}
