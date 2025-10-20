// src/MyOpenTelemetryApi.Domain/Interfaces/IRepository.cs
namespace MyOpenTelemetryApi.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default);
    Task<IEnumerable<T>> GetAllAsync(CancellationToken cancellationToken = default);
    IQueryable<T> GetQueryable(); // Added for efficient querying - no cancellation token needed for synchronous method
    Task AddAsync(T entity, CancellationToken cancellationToken = default);
    void Update(T entity); // Synchronous operation - no cancellation token needed
    void Delete(T entity); // Synchronous operation - no cancellation token needed
}
