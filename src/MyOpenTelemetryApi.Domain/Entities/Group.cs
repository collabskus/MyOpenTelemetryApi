// src/MyOpenTelemetryApi.Domain/Entities/Group.cs
namespace MyOpenTelemetryApi.Domain.Entities;

public class Group
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
    public DateTime CreatedAt { get; set; }

    // Navigation property
    public List<ContactGroup> ContactGroups { get; set; } = [];
}
