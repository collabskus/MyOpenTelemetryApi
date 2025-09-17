// src/MyOpenTelemetryApi.Domain/Entities/ContactGroup.cs (Join table)
namespace MyOpenTelemetryApi.Domain.Entities;

public class ContactGroup
{
    public Guid ContactId { get; set; }
    public Guid GroupId { get; set; }
    public DateTime AddedAt { get; set; }

    // Navigation properties
    public Contact Contact { get; set; } = null!;
    public Group Group { get; set; } = null!;
}
