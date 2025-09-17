// src/MyOpenTelemetryApi.Infrastructure/Data/Configurations/ContactConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Data.Configurations;

public class ContactConfiguration : IEntityTypeConfiguration<Contact>
{
    public void Configure(EntityTypeBuilder<Contact> builder)
    {
        builder.HasKey(c => c.Id);

        builder.Property(c => c.FirstName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.LastName)
            .IsRequired()
            .HasMaxLength(100);

        builder.Property(c => c.MiddleName)
            .HasMaxLength(100);

        builder.Property(c => c.Nickname)
            .HasMaxLength(50);

        builder.Property(c => c.Company)
            .HasMaxLength(200);

        builder.Property(c => c.JobTitle)
            .HasMaxLength(100);

        builder.Property(c => c.Notes)
            .HasMaxLength(1000);

        builder.HasMany(c => c.EmailAddresses)
            .WithOne(e => e.Contact)
            .HasForeignKey(e => e.ContactId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.PhoneNumbers)
            .WithOne(p => p.Contact)
            .HasForeignKey(p => p.ContactId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasMany(c => c.Addresses)
            .WithOne(a => a.Contact)
            .HasForeignKey(a => a.ContactId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}
