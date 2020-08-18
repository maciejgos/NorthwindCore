using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Infrastructure.Configuration
{
    internal class OrderSubtotalsConfiguration : IEntityTypeConfiguration<OrderSubtotals>
    {
        public void Configure(EntityTypeBuilder<OrderSubtotals> builder)
        {
            builder.HasNoKey();

            builder.ToView("Order Subtotals");

            builder.Property(e => e.OrderId).HasColumnName("OrderID");

            builder.Property(e => e.Subtotal).HasColumnType("money");
        }
    }
}
