// src/MyOpenTelemetryApi.Domain/Interfaces/ITagRepository.cs
using MyOpenTelemetryApi.Domain.Entities;

namespace MyOpenTelemetryApi.Domain.Interfaces;

public interface ITagRepository : IRepository<Tag>
{
    Task<Tag?> GetByNameAsync(string name);
}
