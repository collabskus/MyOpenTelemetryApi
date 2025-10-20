// src/MyOpenTelemetryApi.Domain/Interfaces/IContactRepository.cs
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Domain.Interfaces;

public interface IContactRepository : IRepository<Contact>
{
    Task<IEnumerable<Contact>> GetContactsByGroupAsync(Guid groupId, CancellationToken cancellationToken = default);
    Task<IEnumerable<Contact>> GetContactsByTagAsync(Guid tagId, CancellationToken cancellationToken = default);
    Task<Contact?> GetContactWithDetailsAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<Contact>> SearchContactsAsync(string searchTerm, CancellationToken cancellationToken = default);
}
