
// src/MyOpenTelemetryApi.Api/Program.cs - Updated version with configuration-based setup
using System.Diagnostics;
using System.Reflection;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.EntityFrameworkCore;
using MyOpenTelemetryApi.Api.Authentication;
using MyOpenTelemetryApi.Api.Telemetry;
using MyOpenTelemetryApi.Application.Services;
using MyOpenTelemetryApi.Domain.Interfaces;
using MyOpenTelemetryApi.Infrastructure.Data;
using MyOpenTelemetryApi.Infrastructure.Repositories;
using OpenTelemetry.Exporter;
using OpenTelemetry.Logs;
using OpenTelemetry.Metrics;
using OpenTelemetry.Resources;
using OpenTelemetry.Trace;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add authentication
builder.Services.AddAuthentication("ApiKey")
    .AddScheme<ApiKeyAuthenticationOptions, ApiKeyAuthenticationHandler>("ApiKey", null);


// Define service name and version for OpenTelemetry
string serviceName = builder.Configuration.GetValue<string>("OpenTelemetry:ServiceName") ?? "MyOpenTelemetryApi";
string serviceVersion = builder.Configuration.GetValue<string>("OpenTelemetry:ServiceVersion") ??
                    Assembly.GetExecutingAssembly().GetName().Version?.ToString() ?? "1.0.0";

// Configure OpenTelemetry Resource
ResourceBuilder resourceBuilder = ResourceBuilder.CreateDefault()
    .AddService(serviceName: serviceName, serviceVersion: serviceVersion)
    .AddTelemetrySdk()
    .AddAttributes(new Dictionary<string, object>
    {
        ["environment"] = builder.Environment.EnvironmentName,
        ["deployment.environment"] = builder.Environment.EnvironmentName,
        ["host.name"] = Environment.MachineName
    });

// Configure OpenTelemetry Logging
builder.Logging.ClearProviders();
builder.Logging.AddOpenTelemetry(options =>
{
    options.SetResourceBuilder(resourceBuilder);
    options.IncludeFormattedMessage = true;
    options.IncludeScopes = true;

    // Console exporter
    if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:Console:Enabled"))
    {
        options.AddConsoleExporter();
    }

    // File exporter
    if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:File:Enabled"))
    {
        string logPath = builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:File:LogPath")
                     ?? "logs/otel-logs.json";
        options.AddFileExporter(logPath);
    }

    // OTLP exporter
    if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:OTLP:Enabled"))
    {
        options.AddOtlpExporter(otlpOptions =>
        {
            otlpOptions.Endpoint = new Uri(builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:OTLP:Endpoint")
                                          ?? "http://localhost:4317");
            string protocol = builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:OTLP:Protocol") ?? "Grpc";
            otlpOptions.Protocol = protocol == "Grpc" ? OtlpExportProtocol.Grpc : OtlpExportProtocol.HttpProtobuf;
        });
    }
});

// Configure OpenTelemetry Tracing
builder.Services.AddOpenTelemetry()
    .ConfigureResource(resource => resource.AddService(serviceName: serviceName, serviceVersion: serviceVersion))
    .WithTracing(tracing =>
    {
        tracing
            .AddAspNetCoreInstrumentation(options =>
            {
                options.RecordException = true;
                options.Filter = (httpContext) => !httpContext.Request.Path.StartsWithSegments("/health");
            })
            .AddHttpClientInstrumentation(options =>
            {
                options.RecordException = true;
            })
            .AddEntityFrameworkCoreInstrumentation(options =>
            {
                options.SetDbStatementForText = true;
                options.SetDbStatementForStoredProcedure = true;
            })
            .AddSource("MyOpenTelemetryApi.*"); // Add custom activity sources

        // Configure sampling
        bool alwaysOn = builder.Configuration.GetValue<bool>("OpenTelemetry:Sampling:AlwaysOn");
        if (alwaysOn)
        {
            tracing.SetSampler(new AlwaysOnSampler());
        }
        else
        {
            double ratio = builder.Configuration.GetValue<double>("OpenTelemetry:Sampling:Ratio");
            tracing.SetSampler(new TraceIdRatioBasedSampler(ratio));
        }

        // Configure exporters
        if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:Console:Enabled"))
        {
            tracing.AddConsoleExporter();
        }

        if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:OTLP:Enabled"))
        {
            tracing.AddOtlpExporter(options =>
            {
                options.Endpoint = new Uri(builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:OTLP:Endpoint")
                                          ?? "http://localhost:4317");
                string protocol = builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:OTLP:Protocol") ?? "Grpc";
                options.Protocol = protocol == "Grpc" ? OtlpExportProtocol.Grpc : OtlpExportProtocol.HttpProtobuf;
            });
        }
    })
    .WithMetrics(metrics =>
    {
        metrics
            .AddAspNetCoreInstrumentation()
            .AddHttpClientInstrumentation()
            .AddRuntimeInstrumentation()
            .AddProcessInstrumentation()
            .AddMeter("MyOpenTelemetryApi.*"); // Add custom meters

        // Configure exporters
        if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:Console:Enabled"))
        {
            metrics.AddConsoleExporter();
        }

        if (builder.Configuration.GetValue<bool>("OpenTelemetry:Exporter:OTLP:Enabled"))
        {
            metrics.AddOtlpExporter(options =>
            {
                options.Endpoint = new Uri(builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:OTLP:Endpoint")
                                          ?? "http://localhost:4317");
                string protocol = builder.Configuration.GetValue<string>("OpenTelemetry:Exporter:OTLP:Protocol") ?? "Grpc";
                options.Protocol = protocol == "Grpc" ? OtlpExportProtocol.Grpc : OtlpExportProtocol.HttpProtobuf;
            });
        }
    });

// Add services to the container.
builder.Services.AddControllers();

// Configure PostgreSQL
//builder.Services.AddDbContext<AppDbContext>(options =>
//    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection")));
// Program.cs - Add retry policies for database operations
builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), npgsqlOptions =>
    {
        npgsqlOptions.EnableRetryOnFailure(
            maxRetryCount: 3,
            maxRetryDelay: TimeSpan.FromSeconds(30),
            errorCodesToAdd: null);
    });
});

// Register repositories and unit of work
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IContactRepository, ContactRepository>();
builder.Services.AddScoped<IGroupRepository, GroupRepository>();
builder.Services.AddScoped<ITagRepository, TagRepository>();

// Register application services
builder.Services.AddScoped<IContactService, ContactService>();
builder.Services.AddScoped<IGroupService, GroupService>();
builder.Services.AddScoped<ITagService, TagService>();

// Add HTTP context accessor for tracing context
builder.Services.AddHttpContextAccessor();

// Add this to your Program.cs
builder.Services.AddOpenApi(); // Built-in OpenAPI support

WebApplication app = builder.Build();

// Add OpenAPI endpoint
//if (app.Environment.IsDevelopment())
//{
app.MapOpenApi(); // Serves OpenAPI JSON at /openapi/v1.json
//}

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();

// Add custom middleware for request tracing
app.Use(async (context, next) =>
{
    using Activity? activity = Activity.Current;
    if (activity != null)
    {
        activity.SetTag("http.request.body.size", context.Request.ContentLength ?? 0);
        activity.SetTag("user.agent", context.Request.Headers.UserAgent.ToString());
        activity.SetTag("client.ip", context.Connection.RemoteIpAddress?.ToString());
    }

    await next();

    activity?.SetTag("http.response.body.size", context.Response.ContentLength ?? 0);
});

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

// Apply migrations on startup (optional - remove in production)
if (app.Environment.IsDevelopment())
{
    using IServiceScope scope = app.Services.CreateScope();
    AppDbContext dbContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    ILogger<Program> logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

    using Activity? activity = Activity.Current?.Source.StartActivity("DatabaseMigration");
    try
    {
        logger.LogInformation("Applying database migrations...");
        await dbContext.Database.MigrateAsync();
        logger.LogInformation("Database migrations applied successfully.");
    }
    catch (Exception ex)
    {
        logger.LogError(ex, "Error applying database migrations");
        activity?.SetStatus(ActivityStatusCode.Error, ex.Message);
        throw;
    }
}

app.Logger.LogInformation("Starting {ServiceName} version {ServiceVersion}", serviceName, serviceVersion);

// Add a friendly landing page at the root
app.MapGet("/", () => Results.Content("""
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Contact Manager API</title>
    <style>
        * {
            margin: 0;
            padding: 0;
            box-sizing: border-box;
        }
        
        body {
            font-family: -apple-system, BlinkMacSystemFont, 'Segoe UI', Roboto, 'Helvetica Neue', Arial, sans-serif;
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            min-height: 100vh;
            display: flex;
            justify-content: center;
            align-items: center;
            padding: 20px;
        }
        
        .container {
            background: white;
            border-radius: 20px;
            box-shadow: 0 20px 60px rgba(0, 0, 0, 0.3);
            padding: 40px;
            max-width: 600px;
            width: 100%;
            animation: fadeIn 0.6s ease-out;
        }
        
        @keyframes fadeIn {
            from {
                opacity: 0;
                transform: translateY(20px);
            }
            to {
                opacity: 1;
                transform: translateY(0);
            }
        }
        
        h1 {
            color: #333;
            margin-bottom: 10px;
            font-size: 2.5em;
        }
        
        .subtitle {
            color: #666;
            margin-bottom: 30px;
            font-size: 1.2em;
        }
        
        .welcome {
            background: linear-gradient(135deg, #667eea 0%, #764ba2 100%);
            -webkit-background-clip: text;
            -webkit-text-fill-color: transparent;
            background-clip: text;
            font-weight: bold;
            font-size: 1.1em;
            margin-bottom: 20px;
        }
        
        p {
            color: #555;
            line-height: 1.6;
            margin-bottom: 20px;
        }
        
        .endpoints {
            background: #f8f9fa;
            border-radius: 10px;
            padding: 20px;
            margin: 30px 0;
        }
        
        .endpoints h2 {
            color: #333;
            font-size: 1.3em;
            margin-bottom: 15px;
        }
        
        .endpoint-list {
            list-style: none;
        }
        
        .endpoint-list li {
            margin-bottom: 12px;
        }
        
        .endpoint-list a {
            color: #667eea;
            text-decoration: none;
            font-weight: 500;
            display: inline-flex;
            align-items: center;
            transition: all 0.3s ease;
            padding: 8px 12px;
            border-radius: 6px;
            background: white;
        }
        
        .endpoint-list a:hover {
            background: #667eea;
            color: white;
            transform: translateX(5px);
        }
        
        .method {
            background: #28a745;
            color: white;
            padding: 2px 8px;
            border-radius: 4px;
            font-size: 0.85em;
            margin-right: 10px;
            font-weight: bold;
        }
        
        .coming-soon {
            background: #fff3cd;
            border: 1px solid #ffc107;
            color: #856404;
            padding: 15px;
            border-radius: 8px;
            margin-top: 20px;
        }
        
        .coming-soon strong {
            display: block;
            margin-bottom: 5px;
        }
        
        .footer {
            margin-top: 30px;
            padding-top: 20px;
            border-top: 1px solid #e0e0e0;
            text-align: center;
            color: #888;
            font-size: 0.9em;
        }
        
        .tech-stack {
            display: flex;
            gap: 10px;
            justify-content: center;
            margin-top: 15px;
            flex-wrap: wrap;
        }
        
        .tech-badge {
            background: #f0f0f0;
            padding: 4px 10px;
            border-radius: 15px;
            font-size: 0.85em;
            color: #555;
        }
        
        @media (max-width: 480px) {
            h1 {
                font-size: 2em;
            }
            
            .container {
                padding: 30px 20px;
            }
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>📞 Contact Manager API</h1>
        <p class="subtitle">Personal Information Management System</p>
        
        <p class="welcome">Hello, friend! Thank you for checking out this website. 👋</p>
        
        <p>
            This is an API server for managing contacts, groups, and tags. 
            It's built with modern .NET and provides a RESTful interface for 
            personal information management.
        </p>
        
        <div class="endpoints">
            <h2>🔗 Available Endpoints</h2>
            <ul class="endpoint-list">
                <li>
                    <a href="/api/health">
                        <span class="method">GET</span>
                        /api/health - Check service health
                    </a>
                </li>
                <li>
                    <a href="/api/health/ready">
                        <span class="method">GET</span>
                        /api/health/ready - Check service readiness
                    </a>
                </li>
                <li>
                    <a href="/openapi/v1.json">
                        <span class="method">GET</span>
                        /openapi/v1.json - OpenAPI specification
                    </a>
                </li>
            </ul>
        </div>
        
        <div class="coming-soon">
            <strong>🚀 Available Now:</strong>
            The OpenAPI specification is available at /openapi/v1.json. 
            Interactive Swagger UI documentation coming soon!
        </div>
        
        <div class="footer">
            <p>Built with ❤️ using modern technologies</p>
            <div class="tech-stack">
                <span class="tech-badge">.NET 10</span>
                <span class="tech-badge">PostgreSQL</span>
                <span class="tech-badge">OpenTelemetry</span>
                <span class="tech-badge">Docker</span>
            </div>
        </div>
    </div>
</body>
</html>
""", "text/html"));

app.UseExceptionHandler("/error");

app.Map("/error", (HttpContext context) =>
{
    var feature = context.Features.Get<IExceptionHandlerFeature>();
    var logger = context.RequestServices.GetRequiredService<ILogger<Program>>();

    logger.LogError(feature?.Error, "Unhandled exception occurred");

    return Results.Problem(
        detail: "An error occurred processing your request",
        statusCode: 500);
});

app.Run();
