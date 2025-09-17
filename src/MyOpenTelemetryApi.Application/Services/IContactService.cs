// src/MyOpenTelemetryApi.Application/Services/IContactService.cs
using MyOpenTelemetryApi.Application.DTOs;

namespace MyOpenTelemetryApi.Application.Services;

public interface IContactService
{
    Task<ContactDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<ContactDto?> GetWithDetailsAsync(Guid id, CancellationToken cancellationToken = default);
    Task<PaginatedResultDto<ContactSummaryDto>> GetPaginatedAsync(int pageNumber, int pageSize, CancellationToken cancellationToken = default);
    Task<List<ContactSummaryDto>> SearchAsync(string searchTerm, CancellationToken cancellationToken = default);
    Task<ContactDto> CreateAsync(CreateContactDto dto, CancellationToken cancellationToken = default);
    Task<ContactDto?> UpdateAsync(Guid id, UpdateContactDto dto, CancellationToken cancellationToken = default);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default);
    Task<List<ContactSummaryDto>> GetByGroupAsync(Guid groupId, CancellationToken cancellationToken = default);
    Task<List<ContactSummaryDto>> GetByTagAsync(Guid tagId, CancellationToken cancellationToken = default);
}
