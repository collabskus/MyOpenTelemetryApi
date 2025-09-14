# MyOpenTelemetryApi

A RESTful API for managing personal contacts, built with .NET 9, Entity Framework Core, and PostgreSQL. This project demonstrates clean architecture principles, repository pattern, and modern API development practices.

## Features

- **Contact Management**: Full CRUD operations for contacts with detailed information
- **Organization**: Group contacts and apply tags for better organization
- **Search**: Search contacts by name, email, phone, or company
- **Pagination**: Efficient data retrieval with pagination support
- **Clean Architecture**: Separation of concerns with Domain, Application, Infrastructure, and API layers
- **Repository Pattern**: Abstracted data access with Unit of Work pattern
- **PostgreSQL Database**: Using Npgsql provider with Entity Framework Core
- **Health Checks**: Built-in health and readiness endpoints

## Technology Stack

- **.NET 9.0**: Latest framework for high-performance APIs
- **Entity Framework Core 9.0**: Code-first ORM with migrations
- **PostgreSQL**: Open-source relational database
- **xUnit**: Unit testing framework
- **C# 13**: With nullable reference types enabled

## Project Structure

```
MyOpenTelemetryApi/
├── src/
│   ├── MyOpenTelemetryApi.Api/          # Web API controllers and configuration
│   ├── MyOpenTelemetryApi.Domain/       # Domain entities and interfaces
│   ├── MyOpenTelemetryApi.Application/  # Business logic and DTOs
│   └── MyOpenTelemetryApi.Infrastructure/ # Data access and external services
├── tests/
│   ├── MyOpenTelemetryApi.Api.Tests/
│   ├── MyOpenTelemetryApi.Application.Tests/
│   └── MyOpenTelemetryApi.Infrastructure.Tests/
└── MyOpenTelemetryApi.sln
```

## Prerequisites

- .NET 9.0 SDK or later
- PostgreSQL database
- Entity Framework Core tools: `dotnet tool install --global dotnet-ef`

## Getting Started

1. **Clone the repository**
   ```bash
   git clone <repository-url>
   cd MyOpenTelemetryApi
   ```

2. **Configure the database connection**
   
   For development, use user secrets to store the connection string:
   ```bash
   cd src/MyOpenTelemetryApi.Api
   dotnet user-secrets init
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Host=your-host;Database=your-db;Username=your-user;Password=your-password;SSL Mode=Require"
   cd ../..
   ```
   
   For production, use environment variables:
   ```bash
   export ConnectionStrings__DefaultConnection="Host=your-host;Database=your-db;Username=your-user;Password=your-password;SSL Mode=Require"
   ```

3. **Apply database migrations**
   ```bash
   dotnet ef database update --project src/MyOpenTelemetryApi.Infrastructure --startup-project src/MyOpenTelemetryApi.Api
   ```

4. **Run the API**
   ```bash
   dotnet run --project src/MyOpenTelemetryApi.Api
   ```

## API Endpoints

### Contacts
- `GET /api/contacts?pageNumber=1&pageSize=20` - Get paginated contacts
- `GET /api/contacts/{id}` - Get contact with full details
- `GET /api/contacts/search?q=searchterm` - Search contacts
- `GET /api/contacts/group/{groupId}` - Get contacts by group
- `GET /api/contacts/tag/{tagId}` - Get contacts by tag
- `POST /api/contacts` - Create new contact
- `PUT /api/contacts/{id}` - Update contact
- `DELETE /api/contacts/{id}` - Delete contact

### Groups
- `GET /api/groups` - Get all groups
- `GET /api/groups/{id}` - Get group by ID
- `POST /api/groups` - Create new group
- `PUT /api/groups/{id}` - Update group
- `DELETE /api/groups/{id}` - Delete group

### Tags
- `GET /api/tags` - Get all tags
- `GET /api/tags/{id}` - Get tag by ID
- `POST /api/tags` - Create new tag
- `PUT /api/tags/{id}` - Update tag
- `DELETE /api/tags/{id}` - Delete tag

### Health
- `GET /api/health` - Basic health check
- `GET /api/health/ready` - Readiness check with migration status

## Example Requests

### Create a Contact
```json
POST /api/contacts
{
  "firstName": "John",
  "lastName": "Doe",
  "company": "Acme Corp",
  "emailAddresses": [
    {
      "email": "john.doe@example.com",
      "type": "Work",
      "isPrimary": true
    }
  ],
  "phoneNumbers": [
    {
      "number": "+1-555-123-4567",
      "type": "Mobile",
      "isPrimary": true
    }
  ]
}
```

### Create a Group
```json
POST /api/groups
{
  "name": "Friends",
  "description": "Personal friends and family"
}
```

### Create a Tag
```json
POST /api/tags
{
  "name": "VIP",
  "colorHex": "#FF0000"
}
```

## Development

### Running Tests
```bash
dotnet test
```

### Adding Migrations
```bash
dotnet ef migrations add MigrationName --project src/MyOpenTelemetryApi.Infrastructure --startup-project src/MyOpenTelemetryApi.Api --output-dir Data/Migrations
```

### Building for Production
```bash
dotnet publish -c Release -o ./publish
```

## Architecture Decisions

- **Clean Architecture**: Ensures separation of concerns and testability
- **Repository Pattern with Unit of Work**: Provides abstraction over data access
- **DTOs**: Separate data transfer objects from domain entities
- **Manual Mapping**: No dependency on AutoMapper for simple, explicit mapping
- **FOSS Only**: Uses only free and open-source libraries
- **Minimal Dependencies**: Avoids unnecessary packages to reduce complexity

## License
This project is open source and available under the AGPL license.

---
*Notice: This project contains code generated by Large Language Models such as Claude and Gemini. All code is experimental whether explicitly stated or not.*
