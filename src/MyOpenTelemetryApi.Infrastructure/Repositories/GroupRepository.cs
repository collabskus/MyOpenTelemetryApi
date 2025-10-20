// src/MyOpenTelemetryApi.Infrastructure/Repositories/GroupRepository.cs
using Microsoft.EntityFrameworkCore;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;
using MyOpenTelemetryApi.Infrastructure.Data;

namespace MyOpenTelemetryApi.Infrastructure.Repositories;

public class GroupRepository(AppDbContext context) : Repository<Group>(context), IGroupRepository
{
    public async Task<Group?> GetGroupWithContactsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        return await _context.Groups
            .Include(g => g.ContactGroups)
                .ThenInclude(cg => cg.Contact)
            .FirstOrDefaultAsync(g => g.Id == id, cancellationToken);
    }
}
