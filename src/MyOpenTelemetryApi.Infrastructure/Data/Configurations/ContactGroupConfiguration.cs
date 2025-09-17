// src/MyOpenTelemetryApi.Infrastructure/Data/Configurations/ContactGroupConfiguration.cs
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Data.Configurations;

public class ContactGroupConfiguration : IEntityTypeConfiguration<ContactGroup>
{
    public void Configure(EntityTypeBuilder<ContactGroup> builder)
    {
        builder.HasKey(cg => new { cg.ContactId, cg.GroupId });

        builder.HasOne(cg => cg.Contact)
            .WithMany(c => c.ContactGroups)
            .HasForeignKey(cg => cg.ContactId);

        builder.HasOne(cg => cg.Group)
            .WithMany(g => g.ContactGroups)
            .HasForeignKey(cg => cg.GroupId);
    }
}
