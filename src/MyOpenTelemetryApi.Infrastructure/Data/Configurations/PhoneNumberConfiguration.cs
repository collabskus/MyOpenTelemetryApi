// src/MyOpenTelemetryApi.Infrastructure/Data/Configurations/PhoneNumberConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Data.Configurations;

public class PhoneNumberConfiguration : IEntityTypeConfiguration<PhoneNumber>
{
    public void Configure(EntityTypeBuilder<PhoneNumber> builder)
    {
        builder.HasKey(p => p.Id);

        builder.Property(p => p.Number)
            .IsRequired()
            .HasMaxLength(50);

        builder.Property(p => p.Type)
            .HasConversion<string>()
            .HasMaxLength(20);
    }
}
