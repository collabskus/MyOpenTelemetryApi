# Stage 1: Build - Updated 2025-10-06 16:05
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build
WORKDIR /src

# CRITICAL: Copy MSBuild property files FIRST (before .csproj files)
# These files define TargetFramework and package versions
COPY ["Directory.Build.props", "./"]
COPY ["Directory.Packages.props", "./"]

# Copy .csproj files for restore
COPY ["src/MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj", "MyOpenTelemetryApi.Api/"]
COPY ["src/MyOpenTelemetryApi.Application/MyOpenTelemetryApi.Application.csproj", "MyOpenTelemetryApi.Application/"]
COPY ["src/MyOpenTelemetryApi.Domain/MyOpenTelemetryApi.Domain.csproj", "MyOpenTelemetryApi.Domain/"]
COPY ["src/MyOpenTelemetryApi.Infrastructure/MyOpenTelemetryApi.Infrastructure.csproj", "MyOpenTelemetryApi.Infrastructure/"]

RUN dotnet restore "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj"

# Copy source code
COPY src/ .

RUN dotnet publish "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj" -c Release -o /app/publish

# Stage 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:10.0
WORKDIR /app

# Install curl for health checks
RUN apt-get update && apt-get install -y curl && rm -rf /var/lib/apt/lists/*

COPY --from=build /app/publish .

# Create directory for logs with proper permissions
RUN mkdir -p /app/logs && chmod 777 /app/logs

# Use non-root user
USER app

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "MyOpenTelemetryApi.Api.dll"]
