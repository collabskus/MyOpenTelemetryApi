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
                        LogLevel = logRecord.LogLevel.ToString(),
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
            // In .NET 10, LogRecordScope needs to be accessed differently
            var scopeDict = new Dictionary<string, object?>();

            // Try to extract scope values using reflection or ToString()
            // Since we can't directly cast to IEnumerable anymore
            if (scope != null)
            {
                // Get the type and try to iterate if it's enumerable
                var scopeType = scope.GetType();
                if (scope is System.Collections.IEnumerable enumerable and not string)
                {
                    try
                    {
                        foreach (var item in enumerable)
                        {
                            if (item is KeyValuePair<string, object?> kvp)
                            {
                                scopeDict[kvp.Key] = kvp.Value;
                            }
                        }
                    }
                    catch
                    {
                        // If iteration fails, store as string
                        scopeDict["Scope"] = scope.ToString();
                    }
                }
                else
                {
                    // Store non-enumerable scope as string
                    scopeDict["Scope"] = scope.ToString();
                }
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
