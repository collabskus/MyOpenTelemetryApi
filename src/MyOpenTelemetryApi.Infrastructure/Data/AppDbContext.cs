// src/MyOpenTelemetryApi.Infrastructure/Data/AppDbContext.cs
using Microsoft.EntityFrameworkCore;
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Infrastructure.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Contact> Contacts => Set<Contact>();
    public DbSet<EmailAddress> EmailAddresses => Set<EmailAddress>();
    public DbSet<PhoneNumber> PhoneNumbers => Set<PhoneNumber>();
    public DbSet<Address> Addresses => Set<Address>();
    public DbSet<Group> Groups => Set<Group>();
    public DbSet<Tag> Tags => Set<Tag>();
    public DbSet<ContactGroup> ContactGroups => Set<ContactGroup>();
    public DbSet<ContactTag> ContactTags => Set<ContactTag>();

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Apply all configurations from the current assembly
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
