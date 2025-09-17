// Application/Services/IContactService.cs
using MyOpenTelemetryApi.Application.DTOs;

public interface IContactService
{
    Task<PaginatedResultDto<ContactSummaryDto>> GetPaginatedContactsAsync(
        int pageNumber, int pageSize, string? sort, string? filter,
        CancellationToken cancellationToken = default);

    Task<ContactDto?> GetContactByIdAsync(Guid id,
        CancellationToken cancellationToken = default);

    Task<ContactDto> CreateContactAsync(CreateContactDto dto,
        CancellationToken cancellationToken = default);

    Task<ContactDto?> UpdateContactAsync(Guid id, UpdateContactDto dto,
        CancellationToken cancellationToken = default);

    Task DeleteContactAsync(Guid id,
        CancellationToken cancellationToken = default);

    Task<List<ContactSummaryDto>> SearchContactsAsync(string query,
        CancellationToken cancellationToken = default);

    // Update ALL other async methods similarly...
}
