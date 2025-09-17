// src/MyOpenTelemetryApi.Application/Services/ITagService.cs
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Application.Services;

public interface ITagService
{
    Task<TagDto?> GetByIdAsync(Guid id);
    Task<List<TagDto>> GetAllAsync();
    Task<TagDto> CreateAsync(CreateTagDto dto);
    Task<TagDto?> UpdateAsync(Guid id, CreateTagDto dto);
    Task<bool> DeleteAsync(Guid id);
}
