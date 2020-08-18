using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Infrastructure.Configuration
{
    internal class CustomerDemographicsConfiguration : IEntityTypeConfiguration<CustomerDemographics>
    {
        public void Configure(EntityTypeBuilder<CustomerDemographics> builder)
        {
            builder.HasKey(e => e.CustomerTypeId)
                .IsClustered(false);

            builder.Property(e => e.CustomerTypeId)
                .HasColumnName("CustomerTypeID")
                .HasMaxLength(10)
                .IsFixedLength();

            builder.Property(e => e.CustomerDesc).HasColumnType("ntext");
        }
    }
}
