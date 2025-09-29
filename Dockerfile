# Build stage
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# Copy project files
COPY ["src/MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj", "MyOpenTelemetryApi.Api/"]
COPY ["src/MyOpenTelemetryApi.Application/MyOpenTelemetryApi.Application.csproj", "MyOpenTelemetryApi.Application/"]
COPY ["src/MyOpenTelemetryApi.Domain/MyOpenTelemetryApi.Domain.csproj", "MyOpenTelemetryApi.Domain/"]
COPY ["src/MyOpenTelemetryApi.Infrastructure/MyOpenTelemetryApi.Infrastructure.csproj", "MyOpenTelemetryApi.Infrastructure/"]

# Restore dependencies
RUN dotnet restore "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj"

# Copy source code
COPY src/ .

# Build and publish
RUN dotnet publish "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj" -c Release -o /app/publish

# Runtime stage
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

# Copy published application
COPY --from=build /app/publish .
RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

# Create non-root user using proper commands for this base image
RUN groupadd -r appuser && useradd -r -g appuser -d /app -s /bin/false appuser \
    && chown -R appuser:appuser /app

# Switch to non-root user
USER appuser

# Expose ports
EXPOSE 8080
EXPOSE 8081

# Set environment variables
ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

# Entry point
ENTRYPOINT ["dotnet", "MyOpenTelemetryApi.Api.dll"]
