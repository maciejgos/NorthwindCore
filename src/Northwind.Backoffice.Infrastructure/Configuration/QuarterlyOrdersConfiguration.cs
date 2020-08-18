using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Infrastructure.Configuration
{
    internal class QuarterlyOrdersConfiguration : IEntityTypeConfiguration<QuarterlyOrders>
    {
        public void Configure(EntityTypeBuilder<QuarterlyOrders> builder)
        {
            builder.HasNoKey();

            builder.ToView("Quarterly Orders");

            builder.Property(e => e.City).HasMaxLength(15);

            builder.Property(e => e.CompanyName).HasMaxLength(40);

            builder.Property(e => e.Country).HasMaxLength(15);

            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerID")
                .HasMaxLength(5)
                .IsFixedLength();
        }
    }
}
