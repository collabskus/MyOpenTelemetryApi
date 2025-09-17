// src/MyOpenTelemetryApi.Infrastructure/Data/Configurations/ContactTagConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Data.Configurations;

public class ContactTagConfiguration : IEntityTypeConfiguration<ContactTag>
{
    public void Configure(EntityTypeBuilder<ContactTag> builder)
    {
        builder.HasKey(ct => new { ct.ContactId, ct.TagId });

        builder.HasOne(ct => ct.Contact)
            .WithMany(c => c.Tags)
            .HasForeignKey(ct => ct.ContactId);

        builder.HasOne(ct => ct.Tag)
            .WithMany(t => t.ContactTags)
            .HasForeignKey(ct => ct.TagId);
    }
}
