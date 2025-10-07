// src/MyOpenTelemetryApi.Domain/Interfaces/IUnitOfWork.cs
namespace MyOpenTelemetryApi.Domain.Interfaces;

public interface IUnitOfWork
{
    IContactRepository Contacts { get; }
    IGroupRepository Groups { get; }
    ITagRepository Tags { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
