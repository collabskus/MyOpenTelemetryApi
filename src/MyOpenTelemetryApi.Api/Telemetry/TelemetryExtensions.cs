// src/MyOpenTelemetryApi.Api/Telemetry/TelemetryExtensions.cs
using OpenTelemetry;
using OpenTelemetry.Logs;
using OpenTelemetry.Trace;

namespace MyOpenTelemetryApi.Api.Telemetry;

public static class TelemetryExtensions
{
    public static OpenTelemetryLoggerOptions AddFileExporter(
        this OpenTelemetryLoggerOptions options, 
        string filePath)
    {
        return options.AddProcessor(new SimpleLogRecordExportProcessor(new FileLogExporter(filePath)));
    }
    
    public static TracerProviderBuilder AddFileExporter(
        this TracerProviderBuilder builder,
        IConfiguration configuration)
    {
        bool enabled = configuration.GetValue<bool>("OpenTelemetry:Exporter:File:Enabled");
        if (enabled)
        {
            _ = configuration.GetValue<string>("OpenTelemetry:Exporter:File:TracePath")
                           ?? "logs/otel-traces.json";
            // For traces, we'd implement a similar FileTraceExporter
            // For now, we'll use console exporter as file trace export is complex
        }
        
        return builder;
    }
}
