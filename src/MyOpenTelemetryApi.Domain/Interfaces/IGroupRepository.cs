// src/MyOpenTelemetryApi.Domain/Interfaces/IGroupRepository.cs
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Domain.Interfaces;

public interface IGroupRepository : IRepository<Group>
{
    Task<Group?> GetGroupWithContactsAsync(Guid id, CancellationToken cancellationToken = default);
}
