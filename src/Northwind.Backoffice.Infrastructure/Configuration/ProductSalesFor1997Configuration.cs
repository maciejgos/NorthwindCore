using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Infrastructure.Configuration
{
    internal class ProductSalesFor1997Configuration : IEntityTypeConfiguration<ProductSalesFor1997>
    {
        public void Configure(EntityTypeBuilder<ProductSalesFor1997> builder)
        {
            builder.HasNoKey();

            builder.ToView("Product Sales for 1997");

            builder.Property(e => e.CategoryName)
                .IsRequired()
                .HasMaxLength(15);

            builder.Property(e => e.ProductName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(e => e.ProductSales).HasColumnType("money");
        }
    }
}
