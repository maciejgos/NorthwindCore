﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Northwind.Backoffice.Core.Entities;

namespace Northwind.Backoffice.Infrastructure.Configuration
{
    internal class CustomersConfiguration : IEntityTypeConfiguration<Customers>
    {
        public void Configure(EntityTypeBuilder<Customers> builder)
        {
            builder.HasKey(e => e.CustomerId);

            builder.HasIndex(e => e.City)
                .HasName("City");

            builder.HasIndex(e => e.CompanyName)
                .HasName("CompanyName");

            builder.HasIndex(e => e.PostalCode)
                .HasName("PostalCode");

            builder.HasIndex(e => e.Region)
                .HasName("Region");

            builder.Property(e => e.CustomerId)
                .HasColumnName("CustomerID")
                .HasMaxLength(5)
                .IsFixedLength();

            builder.Property(e => e.Address).HasMaxLength(60);

            builder.Property(e => e.City).HasMaxLength(15);

            builder.Property(e => e.CompanyName)
                .IsRequired()
                .HasMaxLength(40);

            builder.Property(e => e.ContactName).HasMaxLength(30);

            builder.Property(e => e.ContactTitle).HasMaxLength(30);

            builder.Property(e => e.Country).HasMaxLength(15);

            builder.Property(e => e.Fax).HasMaxLength(24);

            builder.Property(e => e.Phone).HasMaxLength(24);

            builder.Property(e => e.PostalCode).HasMaxLength(10);

            builder.Property(e => e.Region).HasMaxLength(15);
        }
    }
}