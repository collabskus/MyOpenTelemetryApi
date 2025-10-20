// src/MyOpenTelemetryApi.Application/Services/ITagService.cs
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Application.Services;

public interface ITagService
{
    Task<TagDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<TagDto>> GetAllAsync(CancellationToken cancellationToken = default);
    Task<TagDto> CreateAsync(CreateTagDto dto, CancellationToken cancellationToken = default);
    Task<TagDto?> UpdateAsync(Guid id, CreateTagDto dto, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
}
