// src/MyOpenTelemetryApi.Application/DTOs/TagDto.cs
namespace MyOpenTelemetryApi.Application.DTOs;

public class TagDto
{
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string ColorHex { get; set; } = string.Empty;
}

public class CreateTagDto
{
    public string Name { get; set; } = string.Empty;
    public string ColorHex { get; set; } = string.Empty;
}
