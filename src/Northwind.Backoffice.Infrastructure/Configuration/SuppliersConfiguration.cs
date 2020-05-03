﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Infrastructure.Configuration
{
    class SuppliersConfiguration : IEntityTypeConfiguration<Suppliers>
    {
        public void Configure(EntityTypeBuilder<Suppliers> builder)
        {
            builder.HasKey(e => e.SupplierId);

            builder.HasIndex(e => e.CompanyName)
                .HasName("CompanyName");

            builder.HasIndex(e => e.PostalCode)
                .HasName("PostalCode");

            builder.Property(e => e.SupplierId).HasColumnName("SupplierID");

            builder.Property(e => e.Address).HasMaxLength(60);

            builder.Property(e => e.City).HasMaxLength(15);

            builder.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(e => e.ContactName).HasMaxLength(30);

            builder.Property(e => e.ContactTitle).HasMaxLength(30);

            builder.Property(e => e.Country).HasMaxLength(15);

            builder.Property(e => e.Fax).HasMaxLength(24);

            builder.Property(e => e.HomePage).HasColumnType("ntext");

            builder.Property(e => e.Phone).HasMaxLength(24);

            builder.Property(e => e.PostalCode).HasMaxLength(10);

            builder.Property(e => e.Region).HasMaxLength(15);
        }
    }
}