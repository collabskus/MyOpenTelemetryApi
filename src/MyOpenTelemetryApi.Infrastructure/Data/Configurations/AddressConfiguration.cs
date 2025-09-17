// src/MyOpenTelemetryApi.Infrastructure/Data/Configurations/AddressConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Data.Configurations;

public class AddressConfiguration : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.HasKey(a => a.Id);

        builder.Property(a => a.StreetLine1).HasMaxLength(200);
        builder.Property(a => a.StreetLine2).HasMaxLength(200);
        builder.Property(a => a.City).HasMaxLength(100);
        builder.Property(a => a.StateProvince).HasMaxLength(100);
        builder.Property(a => a.PostalCode).HasMaxLength(20);
        builder.Property(a => a.Country).HasMaxLength(100);

        builder.Property(a => a.Type)
            .HasConversion<string>()
            .HasMaxLength(20);
    }
}
