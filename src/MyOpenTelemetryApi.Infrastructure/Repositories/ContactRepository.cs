// src/MyOpenTelemetryApi.Infrastructure/Repositories/ContactRepository.cs
using Microsoft.EntityFrameworkCore;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;
using MyOpenTelemetryApi.Infrastructure.Data;

namespace MyOpenTelemetryApi.Infrastructure.Repositories;

public class ContactRepository(AppDbContext context) : Repository<Contact>(context), IContactRepository
{
    public async Task<IEnumerable<Contact>> GetContactsByGroupAsync(Guid groupId)
    {
        return await _context.Contacts
            .Include(c => c.ContactGroups)
            .Where(c => c.ContactGroups.Any(cg => cg.GroupId == groupId))
            .ToListAsync();
    }

    public async Task<IEnumerable<Contact>> GetContactsByTagAsync(Guid tagId)
    {
        return await _context.Contacts
            .Include(c => c.Tags)
            .Where(c => c.Tags.Any(ct => ct.TagId == tagId))
            .ToListAsync();
    }

    public async Task<Contact?> GetContactWithDetailsAsync(Guid id)
    {
        return await _context.Contacts
            .Include(c => c.EmailAddresses)
            .Include(c => c.PhoneNumbers)
            .Include(c => c.Addresses)
            .Include(c => c.ContactGroups)
                .ThenInclude(cg => cg.Group)
            .Include(c => c.Tags)
                .ThenInclude(ct => ct.Tag)
            .FirstOrDefaultAsync(c => c.Id == id);
    }

    public async Task<IEnumerable<Contact>> SearchContactsAsync(string searchTerm)
    {
        string lowerSearchTerm = searchTerm.ToLower();

        return await _context.Contacts
            .Include(c => c.EmailAddresses)
            .Include(c => c.PhoneNumbers)
            .Where(c =>
                c.FirstName.ToLower().Contains(lowerSearchTerm) ||
                c.LastName.ToLower().Contains(lowerSearchTerm) ||
                (c.Nickname != null && c.Nickname.ToLower().Contains(lowerSearchTerm)) ||
                (c.Company != null && c.Company.ToLower().Contains(lowerSearchTerm)) ||
                c.EmailAddresses.Any(e => e.Email.ToLower().Contains(lowerSearchTerm)) ||
                c.PhoneNumbers.Any(p => p.Number.Contains(searchTerm)))
            .ToListAsync();
    }
}
