using MyOpenTelemetryApi.Domain.Interfaces;

public interface IUnitOfWork
{
    IContactRepository Contacts { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
