// src/MyOpenTelemetryApi.Application/Services/ContactService.cs
using System.Diagnostics;
using Microsoft.Extensions.Logging;
using MyOpenTelemetryApi.Application.DTOs;
using MyOpenTelemetryApi.Domain.Entities;
using MyOpenTelemetryApi.Domain.Interfaces;

namespace MyOpenTelemetryApi.Application.Services;

public class ContactService(
    IUnitOfWork unitOfWork,
    ILogger<ContactService> logger,
    ActivitySource activitySource) : IContactService
{
    private readonly IUnitOfWork _unitOfWork = unitOfWork;
    private readonly ILogger<ContactService> _logger = logger;
    private readonly ActivitySource _activitySource = activitySource;

    public async Task<List<ContactDto>> GetAllAsync(CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetAllContacts", ActivityKind.Internal);

        _logger.LogInformation("Getting all contacts");

        IEnumerable<Contact> contacts = await _unitOfWork.Contacts.GetAllAsync();
        List<ContactDto> contactDtos = [];
        foreach (Contact contact in contacts)
        {
            contactDtos.Add(MapToDto(contact));
        }

        return contactDtos;
    }

    public async Task<ContactDto?> GetByIdAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactById", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Getting contact by ID: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found with ID: {ContactId}", id);
            return null;
        }

        return MapToDto(contact);
    }

    public async Task<ContactDto?> GetWithDetailsAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactWithDetails", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Getting contact with details by ID: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetContactWithDetailsAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found with ID: {ContactId}", id);
            return null;
        }

        return MapToDto(contact);
    }

    public async Task<PaginatedResultDto<ContactSummaryDto>> GetPaginatedAsync(
        int pageNumber,
        int pageSize,
        CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetPaginatedContacts", ActivityKind.Internal);
        activity?.SetTag("page.number", pageNumber);
        activity?.SetTag("page.size", pageSize);

        _logger.LogInformation("Getting paginated contacts - Page: {PageNumber}, Size: {PageSize}", pageNumber, pageSize);

        // Get the queryable from repository and let it handle the pagination
        IQueryable<Contact> query = _unitOfWork.Contacts.GetQueryable();

        // Get total count
        int totalCount = query.Count();

        // Apply ordering and pagination - these are IQueryable operations, not EF-specific
        var contacts = query
            .OrderBy(c => c.LastName)
            .ThenBy(c => c.FirstName)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize)
            .ToList(); // This executes the query

        // Map to DTOs
        List<ContactSummaryDto> contactSummaries = contacts
            .Select(MapToSummaryDto)
            .ToList();

        return new PaginatedResultDto<ContactSummaryDto>
        {
            Items = contactSummaries,
            PageNumber = pageNumber,
            PageSize = pageSize,
            TotalCount = totalCount
        };
    }

    public async Task<List<ContactSummaryDto>> SearchAsync(string searchTerm, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("SearchContacts", ActivityKind.Internal);
        activity?.SetTag("search.term", searchTerm);

        _logger.LogInformation("Searching contacts with term: {SearchTerm}", searchTerm);

        IEnumerable<Contact> allContacts = await _unitOfWork.Contacts.GetAllAsync();
        List<Contact> matchingContacts = allContacts
            .Where(c =>
                c.FirstName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                c.LastName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                (c.Company != null && c.Company.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
            .ToList();

        List<ContactSummaryDto> results = [];
        foreach (Contact contact in matchingContacts)
        {
            results.Add(MapToSummaryDto(contact));
        }

        return results;
    }

    public async Task<List<ContactSummaryDto>> GetByGroupAsync(Guid groupId, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactsByGroup", ActivityKind.Internal);
        activity?.SetTag("group.id", groupId);

        _logger.LogInformation("Getting contacts by group: {GroupId}", groupId);

        var contacts = await _unitOfWork.Contacts.GetContactsByGroupAsync(groupId);
        return contacts.Select(MapToSummaryDto).ToList();
    }

    public async Task<List<ContactSummaryDto>> GetByTagAsync(Guid tagId, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("GetContactsByTag", ActivityKind.Internal);
        activity?.SetTag("tag.id", tagId);

        _logger.LogInformation("Getting contacts by tag: {TagId}", tagId);

        var contacts = await _unitOfWork.Contacts.GetContactsByTagAsync(tagId);
        return contacts.Select(MapToSummaryDto).ToList();
    }

    public async Task<ContactDto> CreateAsync(CreateContactDto dto, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("CreateContact", ActivityKind.Internal);

        _logger.LogInformation("Creating new contact: {FirstName} {LastName}", dto.FirstName, dto.LastName);

        Contact contact = new()
        {
            Id = Guid.NewGuid(),
            FirstName = dto.FirstName,
            LastName = dto.LastName,
            MiddleName = dto.MiddleName,
            Nickname = dto.Nickname,
            Company = dto.Company,
            JobTitle = dto.JobTitle,
            DateOfBirth = dto.DateOfBirth,
            Notes = dto.Notes,
            CreatedAt = DateTime.UtcNow,
            UpdatedAt = DateTime.UtcNow,
            EmailAddresses = [],
            PhoneNumbers = [],
            Addresses = []
        };

        if (dto.EmailAddresses != null)
        {
            foreach (EmailAddressDto emailDto in dto.EmailAddresses)
            {
                contact.EmailAddresses.Add(new EmailAddress
                {
                    Id = Guid.NewGuid(),
                    Email = emailDto.Email,
                    Type = emailDto.Type,
                    IsPrimary = emailDto.IsPrimary
                });
            }
        }

        if (dto.PhoneNumbers != null)
        {
            foreach (PhoneNumberDto phoneDto in dto.PhoneNumbers)
            {
                contact.PhoneNumbers.Add(new PhoneNumber
                {
                    Id = Guid.NewGuid(),
                    Number = phoneDto.Number,
                    Type = phoneDto.Type,
                    IsPrimary = phoneDto.IsPrimary
                });
            }
        }

        if (dto.Addresses != null)
        {
            foreach (AddressDto addressDto in dto.Addresses)
            {
                contact.Addresses.Add(new Address
                {
                    Id = Guid.NewGuid(),
                    StreetLine1 = addressDto.StreetLine1,
                    StreetLine2 = addressDto.StreetLine2,
                    City = addressDto.City,
                    StateProvince = addressDto.StateProvince,
                    PostalCode = addressDto.PostalCode,
                    Country = addressDto.Country,
                    Type = addressDto.Type,
                    IsPrimary = addressDto.IsPrimary
                });
            }
        }

        await _unitOfWork.Contacts.AddAsync(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("Contact created successfully with ID: {ContactId}", contact.Id);

        return MapToDto(contact);
    }

    public async Task<ContactDto?> UpdateAsync(Guid id, UpdateContactDto dto, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("UpdateContact", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Updating contact: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found for update: {ContactId}", id);
            return null;
        }

        contact.FirstName = dto.FirstName;
        contact.LastName = dto.LastName;
        contact.MiddleName = dto.MiddleName;
        contact.Nickname = dto.Nickname;
        contact.Company = dto.Company;
        contact.JobTitle = dto.JobTitle;
        contact.DateOfBirth = dto.DateOfBirth;
        contact.Notes = dto.Notes;
        contact.UpdatedAt = DateTime.UtcNow;

        _unitOfWork.Contacts.Update(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("Contact updated successfully: {ContactId}", id);

        return MapToDto(contact);
    }

    public async Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken = default)
    {
        using Activity? activity = _activitySource.StartActivity("DeleteContact", ActivityKind.Internal);
        activity?.SetTag("contact.id", id);

        _logger.LogInformation("Deleting contact: {ContactId}", id);

        Contact? contact = await _unitOfWork.Contacts.GetByIdAsync(id);
        if (contact == null)
        {
            _logger.LogWarning("Contact not found for deletion: {ContactId}", id);
            return false;
        }

        _unitOfWork.Contacts.Delete(contact);
        await _unitOfWork.SaveChangesAsync(cancellationToken);

        _logger.LogInformation("Contact deleted successfully: {ContactId}", id);

        return true;
    }

    private static ContactDto MapToDto(Contact contact)
    {
        return new ContactDto
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            MiddleName = contact.MiddleName,
            Nickname = contact.Nickname,
            Company = contact.Company,
            JobTitle = contact.JobTitle,
            DateOfBirth = contact.DateOfBirth,
            Notes = contact.Notes,
            CreatedAt = contact.CreatedAt,
            UpdatedAt = contact.UpdatedAt,
            EmailAddresses = contact.EmailAddresses?.Select(e => new EmailAddressDto
            {
                Email = e.Email,
                Type = e.Type,
                IsPrimary = e.IsPrimary
            }).ToList() ?? [],
            PhoneNumbers = contact.PhoneNumbers?.Select(p => new PhoneNumberDto
            {
                Number = p.Number,
                Type = p.Type,
                IsPrimary = p.IsPrimary
            }).ToList() ?? [],
            Addresses = contact.Addresses?.Select(a => new AddressDto
            {
                StreetLine1 = a.StreetLine1,
                StreetLine2 = a.StreetLine2,
                City = a.City,
                StateProvince = a.StateProvince,
                PostalCode = a.PostalCode,
                Country = a.Country,
                Type = a.Type,
                IsPrimary = a.IsPrimary
            }).ToList() ?? []
        };
    }

    private static ContactSummaryDto MapToSummaryDto(Contact contact)
    {
        return new ContactSummaryDto
        {
            Id = contact.Id,
            FirstName = contact.FirstName,
            LastName = contact.LastName,
            Company = contact.Company,
            PrimaryEmail = contact.EmailAddresses?.FirstOrDefault(e => e.IsPrimary)?.Email,
            PrimaryPhone = contact.PhoneNumbers?.FirstOrDefault(p => p.IsPrimary)?.Number
        };
    }
}
