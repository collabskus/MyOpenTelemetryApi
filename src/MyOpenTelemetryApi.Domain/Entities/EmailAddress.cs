// src/MyOpenTelemetryApi.Domain/Entities/EmailAddress.cs
namespace MyOpenTelemetryApi.Domain.Entities;

public class EmailAddress
{
    public Guid Id { get; set; }
    public Guid ContactId { get; set; }
    public string Email { get; set; } = string.Empty;
    public EmailType Type { get; set; }
    public bool IsPrimary { get; set; }

    // Navigation property
    public Contact Contact { get; set; } = null!;
}
