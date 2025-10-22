// src/MyOpenTelemetryApi.Api/Telemetry/FileExporter.cs
using System.Text.Json;
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Resources;

namespace MyOpenTelemetryApi.Api.Telemetry;

public class FileLogExporter : BaseExporter<LogRecord>
{
    private readonly string _filePath;
    private readonly object _lockObject = new();
    private readonly JsonSerializerOptions _jsonOptions;

    public FileLogExporter(string filePath)
    {
        _filePath = filePath;
        _jsonOptions = new JsonSerializerOptions
        {
            WriteIndented = false,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };

        // Ensure directory exists
        string? directory = Path.GetDirectoryName(_filePath);
        if (!string.IsNullOrEmpty(directory))
        {
            Directory.CreateDirectory(directory);
        }
    }

    public override ExportResult Export(in Batch<LogRecord> batch)
    {
        try
        {
            lock (_lockObject)
            {
                using StreamWriter writer = new(_filePath, append: true);

                foreach (LogRecord logRecord in batch)
                {
                    var logEntry = new
                    {
                        Timestamp = logRecord.Timestamp,
                        TraceId = logRecord.TraceId.ToString(),
                        SpanId = logRecord.SpanId.ToString(),
                        TraceFlags = logRecord.TraceFlags.ToString(),
                        CategoryName = logRecord.CategoryName,
#pragma warning disable OTEL1001
                        Severity = logRecord.Severity.ToString(), // 'OpenTelemetry.Logs.LogRecord.Severity' is for evaluation purposes only and is subject to change or removal in future updates. Suppress this diagnostic to proceed.
#pragma warning restore
                        FormattedMessage = logRecord.FormattedMessage,
                        Body = logRecord.Body,
                        ScopeValues = ExtractScopeValues(logRecord),
                        Exception = logRecord.Exception?.ToString(),
                        Attributes = ExtractAttributes(logRecord)
                    };

                    string json = JsonSerializer.Serialize(logEntry, _jsonOptions);
                    writer.WriteLine(json);
                }
            }

            return ExportResult.Success;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error exporting logs to file: {ex.Message}");
            return ExportResult.Failure;
        }
    }

    private static List<Dictionary<string, object?>> ExtractScopeValues(LogRecord logRecord)
    {
        List<Dictionary<string, object?>> scopes = [];

        logRecord.ForEachScope((scope, state) =>
        {
            var scopeDict = new Dictionary<string, object?>();

            // In .NET 10, LogRecordScope is directly iterable
            foreach (var scopeItem in scope)
            {
                scopeDict[scopeItem.Key] = scopeItem.Value;
            }

            if (scopeDict.Count > 0)
            {
                scopes.Add(scopeDict);
            }
        }, scopes);

        return scopes;
    }

    private static Dictionary<string, object?> ExtractAttributes(LogRecord logRecord)
    {
        Dictionary<string, object?> attributes = [];

        if (logRecord.Attributes != null)
        {
            foreach (KeyValuePair<string, object?> attribute in logRecord.Attributes)
            {
                attributes[attribute.Key] = attribute.Value;
            }
        }

        return attributes;
    }
}
