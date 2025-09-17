// src/MyOpenTelemetryApi.Application/DTOs/ContactDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class ContactDto
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string? Nickname { get; set; }
    public string? Company { get; set; }
    public string? JobTitle { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public string? Notes { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public List<EmailAddressDto> EmailAddresses { get; set; } = [];
    public List<PhoneNumberDto> PhoneNumbers { get; set; } = [];
    public List<AddressDto> Addresses { get; set; } = [];
    public List<GroupDto> Groups { get; set; } = [];
    public List<TagDto> Tags { get; set; } = [];
}
