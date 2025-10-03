// src/MyOpenTelemetryApi.Domain/Interfaces/IRepository.cs
namespace MyOpenTelemetryApi.Domain.Interfaces;

public interface IRepository<T> where T : class
{
    Task<T?> GetByIdAsync(Guid id);
    Task<IEnumerable<T>> GetAllAsync();
    IQueryable<T> GetQueryable(); // Added for efficient querying
    Task AddAsync(T entity);
    void Update(T entity);
    void Delete(T entity);
}
