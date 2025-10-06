? IMeterFactory is working!
LogRecord.Timestamp:               2025-10-06T16:33:34.4041174Z
LogRecord.CategoryName:            Program
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Checking for pending database migrations...
LogRecord.Body:                    Checking for pending database migrations...
LogRecord.Attributes (Key:Value):
    OriginalFormat (a.k.a Body): Checking for pending database migrations...

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:35.8501030Z
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (43ms) [Parameters=[], CommandType='Text', CommandTimeout='30']
SELECT "MigrationId", "ProductVersion"
FROM "__EFMigrationsHistory"
ORDER BY "MigrationId";
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 43
    parameters:
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT "MigrationId", "ProductVersion"
FROM "__EFMigrationsHistory"
ORDER BY "MigrationId";
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:35.8987310Z
LogRecord.CategoryName:            Program
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Database is up to date - no migrations needed.
LogRecord.Body:                    Database is up to date - no migrations needed.
LogRecord.Attributes (Key:Value):
    OriginalFormat (a.k.a Body): Database is up to date - no migrations needed.

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:35.9026633Z
LogRecord.CategoryName:            MyOpenTelemetryApi.Api
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Starting MyOpenTelemetryApi version 1.0.0
LogRecord.Body:                    Starting {ServiceName} version {ServiceVersion}
LogRecord.Attributes (Key:Value):
    ServiceName: MyOpenTelemetryApi
    ServiceVersion: 1.0.0
    OriginalFormat (a.k.a Body): Starting {ServiceName} version {ServiceVersion}

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:35.9052545Z
LogRecord.CategoryName:            Microsoft.Extensions.Hosting.Internal.Host
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        Hosting starting
LogRecord.Body:                    Hosting starting
LogRecord.Attributes (Key:Value):
    OriginalFormat (a.k.a Body): Hosting starting
LogRecord.EventId:                 1
LogRecord.EventName:               Starting

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:35.9273056Z
LogRecord.CategoryName:            Microsoft.AspNetCore.DataProtection.KeyManagement.XmlKeyManager
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        User profile is available. Using 'C:\Users\kushal\AppData\Local\ASP.NET\DataProtection-Keys' as key repository and Windows DPAPI to encrypt keys at rest.
LogRecord.Body:                    User profile is available. Using '{FullName}' as key repository and Windows DPAPI to encrypt keys at rest.
LogRecord.Attributes (Key:Value):
    FullName: C:\Users\kushal\AppData\Local\ASP.NET\DataProtection-Keys
    OriginalFormat (a.k.a Body): User profile is available. Using '{FullName}' as key repository and Windows DPAPI to encrypt keys at rest.
LogRecord.EventId:                 63
LogRecord.EventName:               UsingProfileAsKeyRepositoryWithDPAPI

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:36.0927627Z
LogRecord.CategoryName:            Microsoft.Hosting.Lifetime
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Now listening on: https://0.0.0.0:7034
LogRecord.Body:                    Now listening on: {address}
LogRecord.Attributes (Key:Value):
    address: https://0.0.0.0:7034
    OriginalFormat (a.k.a Body): Now listening on: {address}
LogRecord.EventId:                 14
LogRecord.EventName:               ListeningOnAddress

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:36.0944490Z
LogRecord.CategoryName:            Microsoft.Hosting.Lifetime
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Now listening on: http://0.0.0.0:5174
LogRecord.Body:                    Now listening on: {address}
LogRecord.Attributes (Key:Value):
    address: http://0.0.0.0:5174
    OriginalFormat (a.k.a Body): Now listening on: {address}
LogRecord.EventId:                 14
LogRecord.EventName:               ListeningOnAddress

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:36.2265181Z
LogRecord.CategoryName:            Microsoft.Hosting.Lifetime
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Application started. Press Ctrl+C to shut down.
LogRecord.Body:                    Application started. Press Ctrl+C to shut down.
LogRecord.Attributes (Key:Value):
    OriginalFormat (a.k.a Body): Application started. Press Ctrl+C to shut down.

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:36.2277895Z
LogRecord.CategoryName:            Microsoft.Hosting.Lifetime
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Hosting environment: Development
LogRecord.Body:                    Hosting environment: {EnvName}
LogRecord.Attributes (Key:Value):
    EnvName: Development
    OriginalFormat (a.k.a Body): Hosting environment: {EnvName}

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:36.2290801Z
LogRecord.CategoryName:            Microsoft.Hosting.Lifetime
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Content root path: C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api
LogRecord.Body:                    Content root path: {ContentRoot}
LogRecord.Attributes (Key:Value):
    ContentRoot: C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Content root path: {ContentRoot}

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:33:36.2302167Z
LogRecord.CategoryName:            Microsoft.Extensions.Hosting.Internal.Host
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        Hosting started
LogRecord.Body:                    Hosting started
LogRecord.Attributes (Key:Value):
    OriginalFormat (a.k.a Body): Hosting started
LogRecord.EventId:                 2
LogRecord.EventName:               Started

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9639090Z, 2025-10-06T16:33:45.9803578Z]
Value: 144506880

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9649870Z, 2025-10-06T16:33:45.9804149Z]
Value: 2481056284672

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652033Z, 2025-10-06T16:33:45.9804481Z] process.cpu.state: user
Value: 2
(2025-10-06T16:33:35.9652033Z, 2025-10-06T16:33:45.9804481Z] process.cpu.state: system
Value: 0.328125

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652277Z, 2025-10-06T16:33:45.9804485Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652369Z, 2025-10-06T16:33:45.9804487Z]
Value: 36

Metric Name: dotnet.gc.collections, Description: The number of garbage collections that have occurred since the process has started., Unit: {collection}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:33:45.9804535Z] gc.heap.generation: gen2
Value: 1
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:33:45.9804535Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:33:45.9804535Z] gc.heap.generation: gen0
Value: 2

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665548Z, 2025-10-06T16:33:45.9804541Z]
Value: 144031744

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665597Z, 2025-10-06T16:33:45.9804549Z]
Value: 25792880

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665650Z, 2025-10-06T16:33:45.9804550Z]
Value: 13565952

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:33:45.9804553Z] gc.heap.generation: gen0
Value: 0
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:33:45.9804553Z] gc.heap.generation: gen1
Value: 1042568
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:33:45.9804553Z] gc.heap.generation: gen2
Value: 3800856
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:33:45.9804553Z] gc.heap.generation: loh
Value: 3270784
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:33:45.9804553Z] gc.heap.generation: poh
Value: 58240

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:33:45.9804560Z] gc.heap.generation: gen0
Value: 0
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:33:45.9804560Z] gc.heap.generation: gen1
Value: 602336
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:33:45.9804560Z] gc.heap.generation: gen2
Value: 176104
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:33:45.9804560Z] gc.heap.generation: loh
Value: 736
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:33:45.9804560Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701062Z, 2025-10-06T16:33:45.9804561Z]
Value: 0.014596

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701174Z, 2025-10-06T16:33:45.9804564Z]
Value: 916699

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701251Z, 2025-10-06T16:33:45.9804567Z]
Value: 12367

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701358Z, 2025-10-06T16:33:45.9804569Z]
Value: 1.993818

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701429Z, 2025-10-06T16:33:45.9804571Z]
Value: 0

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701527Z, 2025-10-06T16:33:45.9804573Z]
Value: 3

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701694Z, 2025-10-06T16:33:45.9804576Z]
Value: 55

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701765Z, 2025-10-06T16:33:45.9804577Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701834Z, 2025-10-06T16:33:45.9804579Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701915Z, 2025-10-06T16:33:45.9804581Z]
Value: 166

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9702055Z, 2025-10-06T16:33:45.9804585Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9702132Z, 2025-10-06T16:33:45.9804587Z] cpu.mode: user
Value: 2
(2025-10-06T16:33:35.9702132Z, 2025-10-06T16:33:45.9804587Z] cpu.mode: system
Value: 0.328125




telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.6839161Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:09.6990249Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateContact", controller = "Contacts"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken) on controller MyOpenTelemetryApi.Api.Controllers.ContactsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateContact", controller = "Contacts"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken)
    Controller: MyOpenTelemetryApi.Api.Controllers.ContactsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:09.7146467Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.7164605Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4c449f62eb5bc2bb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Clark-2025-10-06-12-34-08 Kent-2025-10-06-12-34-08
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Clark-2025-10-06-12-34-08
    LastName: Kent-2025-10-06-12-34-08
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4c449f62eb5bc2bb
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4224077fb37c326a
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.7568904Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  d5d024d06d8514c7
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (37ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 37
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d5d024d06d8514c7
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4c449f62eb5bc2bb
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             d5d024d06d8514c7
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4c449f62eb5bc2bb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:09.7195725Z
Activity.Duration:           00:00:00.0393317
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.7962021Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  6069410fb8208d07
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 6069410fb8208d07
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4c449f62eb5bc2bb
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             6069410fb8208d07
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4c449f62eb5bc2bb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:09.7604552Z
Activity.Duration:           00:00:00.0378957
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.8331042Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  dc16ab0ee4c15ea7
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: dc16ab0ee4c15ea7
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4c449f62eb5bc2bb
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             dc16ab0ee4c15ea7
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4c449f62eb5bc2bb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:09.7999103Z
Activity.Duration:           00:00:00.0349990
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.8648049Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  78572cc5edb3e614
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (28ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 28
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78572cc5edb3e614
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4c449f62eb5bc2bb
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             78572cc5edb3e614
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4c449f62eb5bc2bb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:09.8363253Z
Activity.Duration:           00:00:00.0306323
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9043119Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  23278b4467e8bdae
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 23278b4467e8bdae
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4c449f62eb5bc2bb
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             23278b4467e8bdae
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4c449f62eb5bc2bb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:09.8684880Z
Activity.Duration:           00:00:00.0376292
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9450353Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  e37a7682b78d74e0
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?', @p51='?' (DbType = Boolean), @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?', @p58='?' (DbType = Guid), @p59='?' (DbType = Guid), @p60='?' (DbType = Boolean), @p61='?', @p62='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p58, @p59, @p60, @p61, @p62);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?', @p51='?' (DbType = Boolean), @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?', @p58='?' (DbType = Guid), @p59='?' (DbType = Guid), @p60='?' (DbType = Boolean), @p61='?', @p62='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p58, @p59, @p60, @p61, @p62);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: e37a7682b78d74e0
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4c449f62eb5bc2bb
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             e37a7682b78d74e0
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4c449f62eb5bc2bb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:09.9087772Z
Activity.Duration:           00:00:00.0387664
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p58, @p59, @p60, @p61, @p62);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9813362Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4c449f62eb5bc2bb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: a8d9b516-9cac-41a7-bc83-1aa2881914cb
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: a8d9b516-9cac-41a7-bc83-1aa2881914cb
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4c449f62eb5bc2bb
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 4224077fb37c326a
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             4c449f62eb5bc2bb
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4224077fb37c326a
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:34:09.7164456Z
Activity.Duration:           00:00:00.2667298
Activity.Tags:
    contact.id: a8d9b516-9cac-41a7-bc83-1aa2881914cb
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9839919Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 267.5585ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 267.5585
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9858624Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.ContactDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.ContactDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9877138Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 274.0214ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 274.0214
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:09.9894274Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            4b3564822ccf700b0381a54c1805afe9
Activity.SpanId:             4224077fb37c326a
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:09.6802572Z
Activity.Duration:           00:00:00.3383858
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Contacts
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 1653
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:10.0199249Z
LogRecord.TraceId:                 4b3564822ccf700b0381a54c1805afe9
LogRecord.SpanId:                  4224077fb37c326a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 339.6959ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 339.6959
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4224077fb37c326a
[Scope.0]:TraceId: 4b3564822ccf700b0381a54c1805afe9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FS
[Scope.2]:RequestId: 0HNG4UOLJ42FS:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.0656115Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Tags - application/json 70
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 70
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Tags
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.0680831Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.0699798Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:11.0903279Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateTag", controller = "Tags"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.TagDto]] CreateTag(MyOpenTelemetryApi.Application.DTOs.CreateTagDto) on controller MyOpenTelemetryApi.Api.Controllers.TagsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateTag", controller = "Tags"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.TagDto]] CreateTag(MyOpenTelemetryApi.Application.DTOs.CreateTagDto)
    Controller: MyOpenTelemetryApi.Api.Controllers.TagsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:11.1049868Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.1449385Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  651b1f1e76cdb1a8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (37ms) [Parameters=[@ToLower='?'], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 37
    parameters: @ToLower='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 651b1f1e76cdb1a8
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 78f5eaaa0913ba39
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            db5fdbb9c07c46f1dc21fbc3c232fb80
Activity.SpanId:             651b1f1e76cdb1a8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       78f5eaaa0913ba39
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.1077746Z
Activity.Duration:           00:00:00.0396427
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.1852883Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  35c802f372ae001a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (35ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 35
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 35c802f372ae001a
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 78f5eaaa0913ba39
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            db5fdbb9c07c46f1dc21fbc3c232fb80
Activity.SpanId:             35c802f372ae001a
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       78f5eaaa0913ba39
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.1498660Z
Activity.Duration:           00:00:00.0373750
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.1883871Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 81.7142ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 81.7142
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.1901675Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.TagDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.TagDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.1921255Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) in 87.8872ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 87.8872
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.1935876Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            db5fdbb9c07c46f1dc21fbc3c232fb80
Activity.SpanId:             78f5eaaa0913ba39
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:11.0655369Z
Activity.Duration:           00:00:00.1615848
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Tags
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 70
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.2282421Z
LogRecord.TraceId:                 db5fdbb9c07c46f1dc21fbc3c232fb80
LogRecord.SpanId:                  78f5eaaa0913ba39
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Tags - 201 - application/json;+charset=utf-8 162.7393ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 162.7393
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Tags
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 78f5eaaa0913ba39
[Scope.0]:TraceId: db5fdbb9c07c46f1dc21fbc3c232fb80
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FT
[Scope.2]:RequestId: 0HNG4UOLJ42FT:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.2643889Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Tags - application/json 64
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 64
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Tags
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.2665379Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.2678249Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:11.2819281Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateTag", controller = "Tags"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.TagDto]] CreateTag(MyOpenTelemetryApi.Application.DTOs.CreateTagDto) on controller MyOpenTelemetryApi.Api.Controllers.TagsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateTag", controller = "Tags"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.TagDto]] CreateTag(MyOpenTelemetryApi.Application.DTOs.CreateTagDto)
    Controller: MyOpenTelemetryApi.Api.Controllers.TagsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:11.2955928Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.3327119Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  d5187f7ff3e1f1e5
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (35ms) [Parameters=[@ToLower='?'], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 35
    parameters: @ToLower='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d5187f7ff3e1f1e5
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 421b614235180513
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            6fcbad8045a39b9b8037f618cd8b5b61
Activity.SpanId:             d5187f7ff3e1f1e5
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       421b614235180513
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.2980283Z
Activity.Duration:           00:00:00.0368509
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.3693399Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  a4c36bf1a13ae21d
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: a4c36bf1a13ae21d
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 421b614235180513
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            6fcbad8045a39b9b8037f618cd8b5b61
Activity.SpanId:             a4c36bf1a13ae21d
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       421b614235180513
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.3363180Z
Activity.Duration:           00:00:00.0350569
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.3728210Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 75.5427ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 75.5427
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.3757415Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.TagDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.TagDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.3785724Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) in 83.3405ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 83.3405
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.3803452Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            6fcbad8045a39b9b8037f618cd8b5b61
Activity.SpanId:             421b614235180513
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:11.2643275Z
Activity.Duration:           00:00:00.1463028
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Tags
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 64
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.4129746Z
LogRecord.TraceId:                 6fcbad8045a39b9b8037f618cd8b5b61
LogRecord.SpanId:                  421b614235180513
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Tags - 201 - application/json;+charset=utf-8 148.6663ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 148.6663
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Tags
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 421b614235180513
[Scope.0]:TraceId: 6fcbad8045a39b9b8037f618cd8b5b61
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FU
[Scope.2]:RequestId: 0HNG4UOLJ42FU:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.4486610Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Tags - application/json 70
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 70
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Tags
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.4519730Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.4572056Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:11.4825831Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateTag", controller = "Tags"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.TagDto]] CreateTag(MyOpenTelemetryApi.Application.DTOs.CreateTagDto) on controller MyOpenTelemetryApi.Api.Controllers.TagsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateTag", controller = "Tags"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.TagDto]] CreateTag(MyOpenTelemetryApi.Application.DTOs.CreateTagDto)
    Controller: MyOpenTelemetryApi.Api.Controllers.TagsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:11.5046610Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.5373121Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  1d6c0e899c0421c8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (30ms) [Parameters=[@ToLower='?'], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 30
    parameters: @ToLower='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 1d6c0e899c0421c8
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: aadf37f55e526020
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f885f029c326eabaa10897aa1f4c7006
Activity.SpanId:             1d6c0e899c0421c8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       aadf37f55e526020
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.5074837Z
Activity.Duration:           00:00:00.0353425
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.5899896Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  4a3882155c03e349
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (41ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 41
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4a3882155c03e349
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: aadf37f55e526020
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f885f029c326eabaa10897aa1f4c7006
Activity.SpanId:             4a3882155c03e349
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       aadf37f55e526020
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.5489362Z
Activity.Duration:           00:00:00.0505869
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Tags" ("Id", "ColorHex", "Name")
VALUES (@p0, @p1, @p2);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6037120Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 97.0085ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 97.0085
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6056763Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.TagDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.TagDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 62f6f29f-d494-4e77-a8d5-4a409cfa0e80
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6090419Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) in 104.7309ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 104.7309
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6108843Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            f885f029c326eabaa10897aa1f4c7006
Activity.SpanId:             aadf37f55e526020
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:11.4486013Z
Activity.Duration:           00:00:00.1878070
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Tags
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 70
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6375856Z
LogRecord.TraceId:                 f885f029c326eabaa10897aa1f4c7006
LogRecord.SpanId:                  aadf37f55e526020
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Tags - 201 - application/json;+charset=utf-8 189.0047ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 189.0047
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Tags
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aadf37f55e526020
[Scope.0]:TraceId: f885f029c326eabaa10897aa1f4c7006
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42FV
[Scope.2]:RequestId: 0HNG4UOLJ42FV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6723295Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Groups - application/json 97
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 97
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Groups
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6744792Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.6758280Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:11.6925858Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateGroup", controller = "Groups"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.GroupDto]] CreateGroup(MyOpenTelemetryApi.Application.DTOs.CreateGroupDto) on controller MyOpenTelemetryApi.Api.Controllers.GroupsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateGroup", controller = "Groups"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.GroupDto]] CreateGroup(MyOpenTelemetryApi.Application.DTOs.CreateGroupDto)
    Controller: MyOpenTelemetryApi.Api.Controllers.GroupsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:11.7070046Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.7454536Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  b55ca84adffb4a6f
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: b55ca84adffb4a6f
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 7db78b5accf72123
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            2b176c81879325abbe3af256b491661f
Activity.SpanId:             b55ca84adffb4a6f
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       7db78b5accf72123
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.7091241Z
Activity.Duration:           00:00:00.0384760
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.7487326Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 40.3082ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 40.3082
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.7504633Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.GroupDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.GroupDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.7525521Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) in 45.8987ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 45.8987
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.7542401Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            2b176c81879325abbe3af256b491661f
Activity.SpanId:             7db78b5accf72123
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:11.6722869Z
Activity.Duration:           00:00:00.1080068
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Groups
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 97
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.7814581Z
LogRecord.TraceId:                 2b176c81879325abbe3af256b491661f
LogRecord.SpanId:                  7db78b5accf72123
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Groups - 201 - application/json;+charset=utf-8 109.1910ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 109.191
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Groups
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7db78b5accf72123
[Scope.0]:TraceId: 2b176c81879325abbe3af256b491661f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G0
[Scope.2]:RequestId: 0HNG4UOLJ42G0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8155177Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Groups - application/json 102
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 102
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Groups
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8176742Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8192043Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:11.8343339Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateGroup", controller = "Groups"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.GroupDto]] CreateGroup(MyOpenTelemetryApi.Application.DTOs.CreateGroupDto) on controller MyOpenTelemetryApi.Api.Controllers.GroupsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateGroup", controller = "Groups"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.GroupDto]] CreateGroup(MyOpenTelemetryApi.Application.DTOs.CreateGroupDto)
    Controller: MyOpenTelemetryApi.Api.Controllers.GroupsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:11.8482438Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8823072Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  53a05d87ddbdf87e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (31ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 31
    parameters: @p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 53a05d87ddbdf87e
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: f0f02a5242946b80
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            43a3232968aafe4ccfaeb429e272aa0c
Activity.SpanId:             53a05d87ddbdf87e
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       f0f02a5242946b80
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.8516455Z
Activity.Duration:           00:00:00.0323961
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8852256Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 34.4916ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 34.4916
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8868816Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.GroupDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.GroupDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8885982Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) in 40.739ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 40.739
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.8901127Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            43a3232968aafe4ccfaeb429e272aa0c
Activity.SpanId:             f0f02a5242946b80
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:11.8154690Z
Activity.Duration:           00:00:00.1005605
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Groups
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 102
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.9180500Z
LogRecord.TraceId:                 43a3232968aafe4ccfaeb429e272aa0c
LogRecord.SpanId:                  f0f02a5242946b80
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Groups - 201 - application/json;+charset=utf-8 102.6177ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 102.6177
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Groups
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f0f02a5242946b80
[Scope.0]:TraceId: 43a3232968aafe4ccfaeb429e272aa0c
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G1
[Scope.2]:RequestId: 0HNG4UOLJ42G1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.9534752Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Groups - application/json 97
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 97
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Groups
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.9557754Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:11.9573495Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:11.9724222Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateGroup", controller = "Groups"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.GroupDto]] CreateGroup(MyOpenTelemetryApi.Application.DTOs.CreateGroupDto) on controller MyOpenTelemetryApi.Api.Controllers.GroupsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateGroup", controller = "Groups"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.GroupDto]] CreateGroup(MyOpenTelemetryApi.Application.DTOs.CreateGroupDto)
    Controller: MyOpenTelemetryApi.Api.Controllers.GroupsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:11.9879636Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0207489Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  8162065aebafca72
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (30ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 30
    parameters: @p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 8162065aebafca72
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 42d42f2dcbf83858
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            cf4ae675c8a05f00941ce07ae8288f00
Activity.SpanId:             8162065aebafca72
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       42d42f2dcbf83858
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:11.9910252Z
Activity.Duration:           00:00:00.0316057
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0236045Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 33.4892ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 33.4892
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0250815Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.GroupDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.GroupDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: 4dc0a742-1b5e-4e7e-8df2-8aa831de1a51
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0265898Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) in 39.0038ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 39.0038
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0286293Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            cf4ae675c8a05f00941ce07ae8288f00
Activity.SpanId:             42d42f2dcbf83858
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:11.9534327Z
Activity.Duration:           00:00:00.1013390
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Groups
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 97
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0557765Z
LogRecord.TraceId:                 cf4ae675c8a05f00941ce07ae8288f00
LogRecord.SpanId:                  42d42f2dcbf83858
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Groups - 201 - application/json;+charset=utf-8 102.4080ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 102.408
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Groups
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42d42f2dcbf83858
[Scope.0]:TraceId: cf4ae675c8a05f00941ce07ae8288f00
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G2
[Scope.2]:RequestId: 0HNG4UOLJ42G2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0923944Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Contacts - application/json 1616
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 1616
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0943072Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.0957326Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:12.1118001Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateContact", controller = "Contacts"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken) on controller MyOpenTelemetryApi.Api.Controllers.ContactsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateContact", controller = "Contacts"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken)
    Controller: MyOpenTelemetryApi.Api.Controllers.ContactsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:12.1274531Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.1292034Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  ac1e7498e755424e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Adam-2025-10-06-12-34-13 West-2025-10-06-12-34-13
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Adam-2025-10-06-12-34-13
    LastName: West-2025-10-06-12-34-13
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: ac1e7498e755424e
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: d18439f119443ea2
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.1689511Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  28c76bda558fea92
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (37ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 37
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 28c76bda558fea92
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: ac1e7498e755424e
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             28c76bda558fea92
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       ac1e7498e755424e
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.1321278Z
Activity.Duration:           00:00:00.0388728
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.2102378Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  46f290aea63d4175
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (38ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 38
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 46f290aea63d4175
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: ac1e7498e755424e
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             46f290aea63d4175
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       ac1e7498e755424e
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.1723526Z
Activity.Duration:           00:00:00.0401542
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.2488247Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  08f09ffc92a66dda
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (35ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 35
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 08f09ffc92a66dda
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: ac1e7498e755424e
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             08f09ffc92a66dda
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       ac1e7498e755424e
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.2138965Z
Activity.Duration:           00:00:00.0365970
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.2850306Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  42bfe443d825aa5a
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 42bfe443d825aa5a
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: ac1e7498e755424e
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             42bfe443d825aa5a
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       ac1e7498e755424e
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.2517213Z
Activity.Duration:           00:00:00.0352749
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.3257097Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  f326f62830dc3abb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?', @p44='?' (DbType = Boolean), @p45='?', @p46='?' (DbType = Guid), @p47='?' (DbType = Guid), @p48='?', @p49='?' (DbType = Boolean), @p50='?', @p51='?' (DbType = Guid), @p52='?' (DbType = Guid), @p53='?' (DbType = Boolean), @p54='?', @p55='?', @p56='?' (DbType = Guid), @p57='?' (DbType = Guid), @p58='?' (DbType = Boolean), @p59='?', @p60='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p41, @p42, @p43, @p44, @p45);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p46, @p47, @p48, @p49, @p50);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p51, @p52, @p53, @p54, @p55);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p56, @p57, @p58, @p59, @p60);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?', @p44='?' (DbType = Boolean), @p45='?', @p46='?' (DbType = Guid), @p47='?' (DbType = Guid), @p48='?', @p49='?' (DbType = Boolean), @p50='?', @p51='?' (DbType = Guid), @p52='?' (DbType = Guid), @p53='?' (DbType = Boolean), @p54='?', @p55='?', @p56='?' (DbType = Guid), @p57='?' (DbType = Guid), @p58='?' (DbType = Boolean), @p59='?', @p60='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p41, @p42, @p43, @p44, @p45);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p46, @p47, @p48, @p49, @p50);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p51, @p52, @p53, @p54, @p55);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p56, @p57, @p58, @p59, @p60);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: f326f62830dc3abb
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: ac1e7498e755424e
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             f326f62830dc3abb
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       ac1e7498e755424e
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.2894166Z
Activity.Duration:           00:00:00.0392422
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p41, @p42, @p43, @p44, @p45);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p46, @p47, @p48, @p49, @p50);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p51, @p52, @p53, @p54, @p55);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p56, @p57, @p58, @p59, @p60);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.3652088Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  ac1e7498e755424e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: bd591cae-7d7d-4bde-b0af-463ca6bd353f
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: bd591cae-7d7d-4bde-b0af-463ca6bd353f
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: ac1e7498e755424e
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: d18439f119443ea2
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             ac1e7498e755424e
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       d18439f119443ea2
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:34:12.1291869Z
Activity.Duration:           00:00:00.2379897
Activity.Tags:
    contact.id: bd591cae-7d7d-4bde-b0af-463ca6bd353f
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.3680806Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 238.8976ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 238.8976
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.3698411Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.ContactDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.ContactDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.3717797Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 244.9098ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 244.9098
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.3732578Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            448d601dd740e9bae9a81faef78af471
Activity.SpanId:             d18439f119443ea2
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:12.0923252Z
Activity.Duration:           00:00:00.3070819
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Contacts
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 1616
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.4005170Z
LogRecord.TraceId:                 448d601dd740e9bae9a81faef78af471
LogRecord.SpanId:                  d18439f119443ea2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 308.2161ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 308.2161
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d18439f119443ea2
[Scope.0]:TraceId: 448d601dd740e9bae9a81faef78af471
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G3
[Scope.2]:RequestId: 0HNG4UOLJ42G3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.4363632Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Contacts - application/json 1585
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 1585
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.4383667Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.4396433Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:12.4542298Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateContact", controller = "Contacts"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken) on controller MyOpenTelemetryApi.Api.Controllers.ContactsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateContact", controller = "Contacts"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken)
    Controller: MyOpenTelemetryApi.Api.Controllers.ContactsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:12.4695954Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.4709852Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  df5139b3a7775643
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Bruce-2025-10-06-12-34-13 Banner-2025-10-06-12-34-13
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Bruce-2025-10-06-12-34-13
    LastName: Banner-2025-10-06-12-34-13
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: df5139b3a7775643
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 15785f98f0829884
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.5041625Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  8a0b9006059f34ac
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (31ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 31
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 8a0b9006059f34ac
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: df5139b3a7775643
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            deadb0e292bb7d3a3ab104b48c3c4044
Activity.SpanId:             8a0b9006059f34ac
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       df5139b3a7775643
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.4734433Z
Activity.Duration:           00:00:00.0328639
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.5409383Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  99bb9043ddb2611f
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 99bb9043ddb2611f
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: df5139b3a7775643
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            deadb0e292bb7d3a3ab104b48c3c4044
Activity.SpanId:             99bb9043ddb2611f
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       df5139b3a7775643
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.5078330Z
Activity.Duration:           00:00:00.0349085
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.5721584Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  600efc56f5652414
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (28ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 28
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 600efc56f5652414
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: df5139b3a7775643
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            deadb0e292bb7d3a3ab104b48c3c4044
Activity.SpanId:             600efc56f5652414
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       df5139b3a7775643
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.5441396Z
Activity.Duration:           00:00:00.0299753
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6137830Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  1f393dddee813e7b
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (37ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = Guid), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?', @p41='?' (DbType = Boolean), @p42='?', @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?' (DbType = Boolean), @p51='?', @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p34, @p35);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p36, @p37);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p38, @p39, @p40, @p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 37
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = Guid), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?', @p41='?' (DbType = Boolean), @p42='?', @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?' (DbType = Boolean), @p51='?', @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p34, @p35);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p36, @p37);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p38, @p39, @p40, @p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 1f393dddee813e7b
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: df5139b3a7775643
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            deadb0e292bb7d3a3ab104b48c3c4044
Activity.SpanId:             1f393dddee813e7b
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       df5139b3a7775643
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.5762331Z
Activity.Duration:           00:00:00.0406158
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p34, @p35);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p36, @p37);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p38, @p39, @p40, @p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6501057Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  df5139b3a7775643
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: e70b8ada-7a2e-4096-9d8a-441d2f85c13c
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: e70b8ada-7a2e-4096-9d8a-441d2f85c13c
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: df5139b3a7775643
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 15785f98f0829884
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            deadb0e292bb7d3a3ab104b48c3c4044
Activity.SpanId:             df5139b3a7775643
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       15785f98f0829884
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:34:12.4709701Z
Activity.Duration:           00:00:00.1808524
Activity.Tags:
    contact.id: e70b8ada-7a2e-4096-9d8a-441d2f85c13c
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6527404Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 181.7754ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 181.7754
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6545264Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.ContactDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.ContactDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6561681Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 187.065ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 187.065
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6576886Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            deadb0e292bb7d3a3ab104b48c3c4044
Activity.SpanId:             15785f98f0829884
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:12.4363078Z
Activity.Duration:           00:00:00.2453667
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Contacts
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 1585
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.6829426Z
LogRecord.TraceId:                 deadb0e292bb7d3a3ab104b48c3c4044
LogRecord.SpanId:                  15785f98f0829884
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 246.6557ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 246.6557
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 15785f98f0829884
[Scope.0]:TraceId: deadb0e292bb7d3a3ab104b48c3c4044
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G4
[Scope.2]:RequestId: 0HNG4UOLJ42G4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.7207933Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Contacts - application/json 1583
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 1583
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.7229348Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.7242246Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:12.7378456Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateContact", controller = "Contacts"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken) on controller MyOpenTelemetryApi.Api.Controllers.ContactsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateContact", controller = "Contacts"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken)
    Controller: MyOpenTelemetryApi.Api.Controllers.ContactsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:12.7514988Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.7528734Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  3a087ae501957987
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Diana-2025-10-06-12-34-13 Prince-2025-10-06-12-34-13
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Diana-2025-10-06-12-34-13
    LastName: Prince-2025-10-06-12-34-13
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3a087ae501957987
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: fb2c9b866e53db2c
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.7889456Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fa348c97c5ef024e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (34ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 34
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fa348c97c5ef024e
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 3a087ae501957987
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            9716350896d952015b5cdc794f5d920a
Activity.SpanId:             fa348c97c5ef024e
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3a087ae501957987
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.7552885Z
Activity.Duration:           00:00:00.0353741
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.8289569Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  7347b3251c9622eb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (37ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 37
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 7347b3251c9622eb
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 3a087ae501957987
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            9716350896d952015b5cdc794f5d920a
Activity.SpanId:             7347b3251c9622eb
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3a087ae501957987
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.7919541Z
Activity.Duration:           00:00:00.0387444
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.8690899Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  e157ec374aaa33b7
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (37ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 37
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: e157ec374aaa33b7
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 3a087ae501957987
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            9716350896d952015b5cdc794f5d920a
Activity.SpanId:             e157ec374aaa33b7
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3a087ae501957987
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.8321904Z
Activity.Duration:           00:00:00.0389019
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9066457Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  5b15e3a1688fdc66
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?', @p42='?' (DbType = Boolean), @p43='?', @p44='?' (DbType = Guid), @p45='?' (DbType = Guid), @p46='?', @p47='?' (DbType = Boolean), @p48='?', @p49='?' (DbType = Guid), @p50='?' (DbType = Guid), @p51='?' (DbType = Boolean), @p52='?', @p53='?', @p54='?' (DbType = Guid), @p55='?' (DbType = Guid), @p56='?' (DbType = Boolean), @p57='?', @p58='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p39, @p40, @p41, @p42, @p43);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p44, @p45, @p46, @p47, @p48);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p49, @p50, @p51, @p52, @p53);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p54, @p55, @p56, @p57, @p58);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?', @p42='?' (DbType = Boolean), @p43='?', @p44='?' (DbType = Guid), @p45='?' (DbType = Guid), @p46='?', @p47='?' (DbType = Boolean), @p48='?', @p49='?' (DbType = Guid), @p50='?' (DbType = Guid), @p51='?' (DbType = Boolean), @p52='?', @p53='?', @p54='?' (DbType = Guid), @p55='?' (DbType = Guid), @p56='?' (DbType = Boolean), @p57='?', @p58='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p39, @p40, @p41, @p42, @p43);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p44, @p45, @p46, @p47, @p48);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p49, @p50, @p51, @p52, @p53);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p54, @p55, @p56, @p57, @p58);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 5b15e3a1688fdc66
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 3a087ae501957987
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            9716350896d952015b5cdc794f5d920a
Activity.SpanId:             5b15e3a1688fdc66
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3a087ae501957987
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:12.8733254Z
Activity.Duration:           00:00:00.0359468
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p39, @p40, @p41, @p42, @p43);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p44, @p45, @p46, @p47, @p48);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p49, @p50, @p51, @p52, @p53);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p54, @p55, @p56, @p57, @p58);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9453506Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  3a087ae501957987
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: f400e560-e40d-43a3-b569-669eacc307cc
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: f400e560-e40d-43a3-b569-669eacc307cc
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3a087ae501957987
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: fb2c9b866e53db2c
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            9716350896d952015b5cdc794f5d920a
Activity.SpanId:             3a087ae501957987
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       fb2c9b866e53db2c
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:34:12.7528571Z
Activity.Duration:           00:00:00.1943567
Activity.Tags:
    contact.id: f400e560-e40d-43a3-b569-669eacc307cc
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9480489Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 195.2059ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 195.2059
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9496618Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.ContactDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.ContactDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9513503Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 200.3283ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 200.3283
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9527508Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            9716350896d952015b5cdc794f5d920a
Activity.SpanId:             fb2c9b866e53db2c
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:12.7207456Z
Activity.Duration:           00:00:00.2547932
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Contacts
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 1583
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:12.9765093Z
LogRecord.TraceId:                 9716350896d952015b5cdc794f5d920a
LogRecord.SpanId:                  fb2c9b866e53db2c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 255.7897ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 255.7897
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: fb2c9b866e53db2c
[Scope.0]:TraceId: 9716350896d952015b5cdc794f5d920a
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G5
[Scope.2]:RequestId: 0HNG4UOLJ42G5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.0161188Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Contacts - application/json 1541
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 1541
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.0180394Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.0192969Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:13.0339667Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateContact", controller = "Contacts"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken) on controller MyOpenTelemetryApi.Api.Controllers.ContactsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateContact", controller = "Contacts"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken)
    Controller: MyOpenTelemetryApi.Api.Controllers.ContactsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:13.0479244Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.0496621Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  acb44f05ccb2ccd6
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Peter-2025-10-06-12-34-13 Parker-2025-10-06-12-34-13
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Peter-2025-10-06-12-34-13
    LastName: Parker-2025-10-06-12-34-13
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: acb44f05ccb2ccd6
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 56a06c87af489d15
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.0843945Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  d913c226c035d42e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (32ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 32
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d913c226c035d42e
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: acb44f05ccb2ccd6
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f2a5fa3f1dc8e410c70655014eb209b7
Activity.SpanId:             d913c226c035d42e
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       acb44f05ccb2ccd6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.0526400Z
Activity.Duration:           00:00:00.0335270
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.1251951Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  a84a456e04e1ae6c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (38ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 38
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: a84a456e04e1ae6c
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: acb44f05ccb2ccd6
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f2a5fa3f1dc8e410c70655014eb209b7
Activity.SpanId:             a84a456e04e1ae6c
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       acb44f05ccb2ccd6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.0874217Z
Activity.Duration:           00:00:00.0396717
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.1635453Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  30669c4d2935150f
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (34ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = Guid), @p37='?' (DbType = Guid), @p38='?', @p39='?' (DbType = Boolean), @p40='?', @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?', @p44='?' (DbType = Boolean), @p45='?', @p46='?' (DbType = Guid), @p47='?' (DbType = Guid), @p48='?' (DbType = Boolean), @p49='?', @p50='?', @p51='?' (DbType = Guid), @p52='?' (DbType = Guid), @p53='?' (DbType = Boolean), @p54='?', @p55='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p34, @p35);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p36, @p37, @p38, @p39, @p40);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p41, @p42, @p43, @p44, @p45);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p46, @p47, @p48, @p49, @p50);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p51, @p52, @p53, @p54, @p55);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 34
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = Guid), @p37='?' (DbType = Guid), @p38='?', @p39='?' (DbType = Boolean), @p40='?', @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?', @p44='?' (DbType = Boolean), @p45='?', @p46='?' (DbType = Guid), @p47='?' (DbType = Guid), @p48='?' (DbType = Boolean), @p49='?', @p50='?', @p51='?' (DbType = Guid), @p52='?' (DbType = Guid), @p53='?' (DbType = Boolean), @p54='?', @p55='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p34, @p35);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p36, @p37, @p38, @p39, @p40);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p41, @p42, @p43, @p44, @p45);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p46, @p47, @p48, @p49, @p50);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p51, @p52, @p53, @p54, @p55);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 30669c4d2935150f
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: acb44f05ccb2ccd6
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f2a5fa3f1dc8e410c70655014eb209b7
Activity.SpanId:             30669c4d2935150f
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       acb44f05ccb2ccd6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.1290953Z
Activity.Duration:           00:00:00.0368611
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p34, @p35);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p36, @p37, @p38, @p39, @p40);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p41, @p42, @p43, @p44, @p45);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p46, @p47, @p48, @p49, @p50);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p51, @p52, @p53, @p54, @p55);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2013864Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  acb44f05ccb2ccd6
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: 8de7114d-e2ba-4033-b9c7-6879e4bc0c63
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: 8de7114d-e2ba-4033-b9c7-6879e4bc0c63
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: acb44f05ccb2ccd6
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 56a06c87af489d15
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f2a5fa3f1dc8e410c70655014eb209b7
Activity.SpanId:             acb44f05ccb2ccd6
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       56a06c87af489d15
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:34:13.0496435Z
Activity.Duration:           00:00:00.1534487
Activity.Tags:
    contact.id: 8de7114d-e2ba-4033-b9c7-6879e4bc0c63
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2038471Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 154.209ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 154.209
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2057378Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.ContactDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.ContactDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2075792Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 160.2127ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 160.2127
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2092288Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            f2a5fa3f1dc8e410c70655014eb209b7
Activity.SpanId:             56a06c87af489d15
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:13.0160775Z
Activity.Duration:           00:00:00.2204168
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Contacts
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 1541
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2376012Z
LogRecord.TraceId:                 f2a5fa3f1dc8e410c70655014eb209b7
LogRecord.SpanId:                  56a06c87af489d15
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 221.5412ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 221.5412
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 56a06c87af489d15
[Scope.0]:TraceId: f2a5fa3f1dc8e410c70655014eb209b7
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G6
[Scope.2]:RequestId: 0HNG4UOLJ42G6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2814723Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request starting HTTP/2 POST https://192.168.0.80:7034/api/Contacts - application/json 1653
LogRecord.Body:                    Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.Attributes (Key:Value):
    Protocol: HTTP/2
    Method: POST
    ContentType: application/json
    ContentLength: 1653
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request starting {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {ContentType} {ContentLength}
LogRecord.EventId:                 1
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2836832Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Api.Authentication.ApiKeyAuthenticationHandler
LogRecord.Severity:                Debug
LogRecord.SeverityText:            Debug
LogRecord.FormattedMessage:        AuthenticationScheme: ApiKey was not authenticated.
LogRecord.Body:                    AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.Attributes (Key:Value):
    AuthenticationScheme: ApiKey
    OriginalFormat (a.k.a Body): AuthenticationScheme: {AuthenticationScheme} was not authenticated.
LogRecord.EventId:                 9
LogRecord.EventName:               AuthenticationSchemeNotAuthenticated
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.2851123Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executing endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executing endpoint '{EndpointName}'
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:34:13.3004509Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Route matched with {action = "CreateContact", controller = "Contacts"}. Executing controller action with signature System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken) on controller MyOpenTelemetryApi.Api.Controllers.ContactsController (MyOpenTelemetryApi.Api).
LogRecord.Body:                    Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.Attributes (Key:Value):
    RouteData: {action = "CreateContact", controller = "Contacts"}
    MethodInfo: System.Threading.Tasks.Task`1[Microsoft.AspNetCore.Mvc.ActionResult`1[MyOpenTelemetryApi.Application.DTOs.ContactDto]] CreateContact(MyOpenTelemetryApi.Application.DTOs.CreateContactDto, System.Threading.CancellationToken)
    Controller: MyOpenTelemetryApi.Api.Controllers.ContactsController
    AssemblyName: MyOpenTelemetryApi.Api
    OriginalFormat (a.k.a Body): Route matched with {RouteData}. Executing controller action with signature {MethodInfo} on controller {Controller} ({AssemblyName}).
LogRecord.EventId:                 102
LogRecord.EventName:               ControllerActionExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:34:13.3153234Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) - Validation state: Valid
LogRecord.Body:                    Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ValidationState: Valid
    OriginalFormat (a.k.a Body): Executing action method {ActionName} - Validation state: {ValidationState}
LogRecord.EventId:                 101
LogRecord.EventName:               ActionMethodExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.3170458Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  e6e5c42e55f62f92
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Clark-2025-10-06-12-34-13 Kent-2025-10-06-12-34-13
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Clark-2025-10-06-12-34-13
    LastName: Kent-2025-10-06-12-34-13
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: e6e5c42e55f62f92
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 3997fdcfca3fe3fa
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.3484504Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  d519751380d4acd8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (29ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 29
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d519751380d4acd8
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: e6e5c42e55f62f92
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             d519751380d4acd8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       e6e5c42e55f62f92
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.3195894Z
Activity.Duration:           00:00:00.0310990
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.3804700Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3d341d9c52257206
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (28ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 28
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3d341d9c52257206
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: e6e5c42e55f62f92
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             3d341d9c52257206
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       e6e5c42e55f62f92
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.3521244Z
Activity.Duration:           00:00:00.0304816
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.4172697Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  0caed7080ed2d074
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 0caed7080ed2d074
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: e6e5c42e55f62f92
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             0caed7080ed2d074
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       e6e5c42e55f62f92
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.3839982Z
Activity.Duration:           00:00:00.0352570
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.4491414Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  ce4e72741262e6fb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (28ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 28
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: ce4e72741262e6fb
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: e6e5c42e55f62f92
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             ce4e72741262e6fb
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       e6e5c42e55f62f92
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.4206694Z
Activity.Duration:           00:00:00.0305565
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.4885095Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  20f1a6e5d457ca36
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p='?' (DbType = Guid)
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 20f1a6e5d457ca36
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: e6e5c42e55f62f92
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             20f1a6e5d457ca36
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       e6e5c42e55f62f92
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.4527746Z
Activity.Duration:           00:00:00.0377558
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5292147Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  582d834bff9af7bb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (36ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?', @p51='?' (DbType = Boolean), @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?', @p58='?' (DbType = Guid), @p59='?' (DbType = Guid), @p60='?' (DbType = Boolean), @p61='?', @p62='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p58, @p59, @p60, @p61, @p62);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 36
    parameters: @p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?', @p51='?' (DbType = Boolean), @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?', @p58='?' (DbType = Guid), @p59='?' (DbType = Guid), @p60='?' (DbType = Boolean), @p61='?', @p62='?'
    commandType: Text
    commandTimeout: 30
    newLine:

    commandText: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p58, @p59, @p60, @p61, @p62);
    OriginalFormat (a.k.a Body): Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.EventId:                 20101
LogRecord.EventName:               Microsoft.EntityFrameworkCore.Database.Command.CommandExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 582d834bff9af7bb
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: e6e5c42e55f62f92
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             582d834bff9af7bb
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       e6e5c42e55f62f92
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:34:13.4931254Z
Activity.Duration:           00:00:00.0386299
Activity.Tags:
    db.system: postgresql
    server.address: tcp://ep-late-dawn-aerv42ii-pooler.c-2.us-east-2.aws.neon.tech:5432
    db.name: neondb
    db.statement: INSERT INTO "Contacts" ("Id", "Company", "CreatedAt", "DateOfBirth", "FirstName", "JobTitle", "LastName", "MiddleName", "Nickname", "Notes", "UpdatedAt")
VALUES (@p0, @p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p11, @p12, @p13, @p14, @p15, @p16, @p17, @p18, @p19, @p20);
INSERT INTO "Addresses" ("Id", "City", "ContactId", "Country", "IsPrimary", "PostalCode", "StateProvince", "StreetLine1", "StreetLine2", "Type")
VALUES (@p21, @p22, @p23, @p24, @p25, @p26, @p27, @p28, @p29, @p30);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p31, @p32, @p33);
INSERT INTO "ContactGroups" ("ContactId", "GroupId", "AddedAt")
VALUES (@p34, @p35, @p36);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p37, @p38);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p39, @p40);
INSERT INTO "ContactTags" ("ContactId", "TagId")
VALUES (@p41, @p42);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p43, @p44, @p45, @p46, @p47);
INSERT INTO "EmailAddresses" ("Id", "ContactId", "Email", "IsPrimary", "Type")
VALUES (@p48, @p49, @p50, @p51, @p52);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p53, @p54, @p55, @p56, @p57);
INSERT INTO "PhoneNumbers" ("Id", "ContactId", "IsPrimary", "Number", "Type")
VALUES (@p58, @p59, @p60, @p61, @p62);

Instrumentation scope (ActivitySource):
    Name: OpenTelemetry.Instrumentation.EntityFrameworkCore
    Version: 1.12.0-beta.2
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5654131Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  e6e5c42e55f62f92
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: f08fb20e-bdaa-4c1c-9f62-6639e3e35813
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: f08fb20e-bdaa-4c1c-9f62-6639e3e35813
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: e6e5c42e55f62f92
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 3997fdcfca3fe3fa
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             e6e5c42e55f62f92
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3997fdcfca3fe3fa
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:34:13.3170322Z
Activity.Duration:           00:00:00.2498006
Activity.Tags:
    contact.id: f08fb20e-bdaa-4c1c-9f62-6639e3e35813
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5675247Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 250.5039ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 250.5039
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5688811Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ObjectResultExecutor
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executing CreatedAtActionResult, writing value of type 'MyOpenTelemetryApi.Application.DTOs.ContactDto'.
LogRecord.Body:                    Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.Attributes (Key:Value):
    ObjectResultType: CreatedAtActionResult
    Type: MyOpenTelemetryApi.Application.DTOs.ContactDto
    OriginalFormat (a.k.a Body): Executing {ObjectResultType}, writing value of type '{Type}'.
LogRecord.EventId:                 1
LogRecord.EventName:               ObjectResultExecuting
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 3b45e7d1-de35-41e8-9ab6-b159817daecc
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5703443Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 255.5099ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 255.5099
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5715806Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Routing.EndpointMiddleware
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed endpoint 'MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)'
LogRecord.Body:                    Executed endpoint '{EndpointName}'
LogRecord.Attributes (Key:Value):
    EndpointName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    OriginalFormat (a.k.a Body): Executed endpoint '{EndpointName}'
LogRecord.EventId:                 1
LogRecord.EventName:               ExecutedEndpoint
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            e57aeca417daf3523305a967c2592760
Activity.SpanId:             3997fdcfca3fe3fa
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:34:13.2814308Z
Activity.Duration:           00:00:00.3123653
Activity.Tags:
    server.address: 192.168.0.80
    server.port: 7034
    http.request.method: POST
    url.scheme: https
    url.path: /api/Contacts
    network.protocol.version: 2
    user_agent.original: curl/8.14.1
    http.request.body.size: 1653
    user.agent: curl/8.14.1
    client.ip: 192.168.0.120
    http.response.body.size: 0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:34:13.5947536Z
LogRecord.TraceId:                 e57aeca417daf3523305a967c2592760
LogRecord.SpanId:                  3997fdcfca3fe3fa
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 313.3415ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 313.3415
    StatusCode: 201
    ContentType: application/json; charset=utf-8
    ContentLength:
    Protocol: HTTP/2
    Method: POST
    Scheme: https
    Host: 192.168.0.80:7034
    PathBase:
    Path: /api/Contacts
    QueryString:
    OriginalFormat (a.k.a Body): Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.EventId:                 2
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3997fdcfca3fe3fa
[Scope.0]:TraceId: e57aeca417daf3523305a967c2592760
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4UOLJ42G7
[Scope.2]:RequestId: 0HNG4UOLJ42G7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9639090Z, 2025-10-06T16:34:16.0554457Z]
Value: 218050560

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9649870Z, 2025-10-06T16:34:16.0554461Z]
Value: 2481115238400

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652033Z, 2025-10-06T16:34:16.0554465Z] process.cpu.state: user
Value: 6.484375
(2025-10-06T16:33:35.9652033Z, 2025-10-06T16:34:16.0554465Z] process.cpu.state: system
Value: 0.859375

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652277Z, 2025-10-06T16:34:16.0554467Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652369Z, 2025-10-06T16:34:16.0554468Z]
Value: 41

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9652531Z, 2025-10-06T16:34:16.0554473Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9657932Z, 2025-10-06T16:34:16.0554480Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 5.3863993 Count: 22 Min: 0.1107307 Max: 0.711793
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:10
(0.2,0.5]:10
(0.5,1]:2
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:0
(120,300]:0
(300,+Infinity]:0


Metric Name: kestrel.queued_connections, Description: Number of connections that are currently queued and are waiting to start., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658179Z, 2025-10-06T16:34:16.0554487Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658271Z, 2025-10-06T16:34:16.0554490Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658578Z, 2025-10-06T16:34:16.0554500Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.14036469999999998 Count: 22 Min: 0.0055879 Max: 0.0095863
(-Infinity,0.005]:0
(0.005,0.01]:22
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0


Metric Name: kestrel.active_tls_handshakes, Description: Number of TLS handshakes that are currently in progress on the server., Unit: {handshake}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658712Z, 2025-10-06T16:34:16.0554503Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:33:35.9665295Z, 2025-10-06T16:34:16.0554509Z] http.request.method: POST url.scheme: https
Value: 0

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:33:35.9665404Z, 2025-10-06T16:34:16.0554523Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 1.5320976999999998 Count: 6 Min: 0.1486663 Max: 0.6729304
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:5
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:33:35.9665404Z, 2025-10-06T16:34:16.0554523Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 0.6624161 Count: 6 Min: 0.102408 Max: 0.1323369
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:6
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:33:35.9665404Z, 2025-10-06T16:34:16.0554523Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 2.9588364 Count: 10 Min: 0.2215412 Max: 0.5106006
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:3
(0.25,0.5]:6
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0


Metric Name: dotnet.gc.collections, Description: The number of garbage collections that have occurred since the process has started., Unit: {collection}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:34:16.0554525Z] gc.heap.generation: gen2
Value: 1
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:34:16.0554525Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:34:16.0554525Z] gc.heap.generation: gen0
Value: 2

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665548Z, 2025-10-06T16:34:16.0554527Z]
Value: 218079232

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665597Z, 2025-10-06T16:34:16.0554528Z]
Value: 50581512

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665650Z, 2025-10-06T16:34:16.0554529Z]
Value: 13565952

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:16.0554530Z] gc.heap.generation: gen0
Value: 0
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:16.0554530Z] gc.heap.generation: gen1
Value: 1042568
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:16.0554530Z] gc.heap.generation: gen2
Value: 3800856
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:16.0554530Z] gc.heap.generation: loh
Value: 3270784
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:16.0554530Z] gc.heap.generation: poh
Value: 58240

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:16.0554533Z] gc.heap.generation: gen0
Value: 0
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:16.0554533Z] gc.heap.generation: gen1
Value: 602336
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:16.0554533Z] gc.heap.generation: gen2
Value: 176104
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:16.0554533Z] gc.heap.generation: loh
Value: 736
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:16.0554533Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701062Z, 2025-10-06T16:34:16.0554534Z]
Value: 0.014596

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701174Z, 2025-10-06T16:34:16.0554538Z]
Value: 2332434

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701251Z, 2025-10-06T16:34:16.0554539Z]
Value: 29983

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701358Z, 2025-10-06T16:34:16.0554540Z]
Value: 6.7026968

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701429Z, 2025-10-06T16:34:16.0554543Z]
Value: 3

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701527Z, 2025-10-06T16:34:16.0554544Z]
Value: 6

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701694Z, 2025-10-06T16:34:16.0554546Z]
Value: 1197

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701765Z, 2025-10-06T16:34:16.0554547Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701834Z, 2025-10-06T16:34:16.0554548Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701915Z, 2025-10-06T16:34:16.0554549Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701984Z, 2025-10-06T16:34:16.0554553Z] error.type: NotSupportedException
Value: 132

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9702055Z, 2025-10-06T16:34:16.0554555Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9702132Z, 2025-10-06T16:34:16.0554557Z] cpu.mode: user
Value: 6.484375
(2025-10-06T16:33:35.9702132Z, 2025-10-06T16:34:16.0554557Z] cpu.mode: system
Value: 0.859375

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:33:36.0222280Z, 2025-10-06T16:34:16.0554560Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 6
(2025-10-06T16:33:36.0222280Z, 2025-10-06T16:34:16.0554560Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 6
(2025-10-06T16:33:36.0222280Z, 2025-10-06T16:34:16.0554560Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 10

Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Wayne Enterprises-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Stark Industries-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Themyscira Inc-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Daily Bugle-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Daily Planet-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Wayne Enterprises-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Stark Industries-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Themyscira Inc-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Daily Bugle-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:16.0554568Z] company: Daily Planet-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 160b2c6c-5d28-4087-8074-d4fd984e27a2
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9639090Z, 2025-10-06T16:34:25.9604053Z]
Value: 208486400

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9649870Z, 2025-10-06T16:34:25.9604058Z]
Value: 2481115238400

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652033Z, 2025-10-06T16:34:25.9604061Z] process.cpu.state: user
Value: 6.5
(2025-10-06T16:33:35.9652033Z, 2025-10-06T16:34:25.9604061Z] process.cpu.state: system
Value: 0.875

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652277Z, 2025-10-06T16:34:25.9604063Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:33:35.9652369Z, 2025-10-06T16:34:25.9604065Z]
Value: 41

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9652531Z, 2025-10-06T16:34:25.9604088Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9657932Z, 2025-10-06T16:34:25.9604094Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 5.3863993 Count: 22 Min: 0.1107307 Max: 0.711793
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:10
(0.2,0.5]:10
(0.5,1]:2
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:0
(120,300]:0
(300,+Infinity]:0


Metric Name: kestrel.queued_connections, Description: Number of connections that are currently queued and are waiting to start., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658179Z, 2025-10-06T16:34:25.9604101Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658271Z, 2025-10-06T16:34:25.9604106Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658578Z, 2025-10-06T16:34:25.9604115Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.14036469999999998 Count: 22 Min: 0.0055879 Max: 0.0095863
(-Infinity,0.005]:0
(0.005,0.01]:22
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0


Metric Name: kestrel.active_tls_handshakes, Description: Number of TLS handshakes that are currently in progress on the server., Unit: {handshake}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:33:35.9658712Z, 2025-10-06T16:34:25.9604119Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:33:35.9665295Z, 2025-10-06T16:34:25.9604124Z] http.request.method: POST url.scheme: https
Value: 0

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:33:35.9665404Z, 2025-10-06T16:34:25.9604135Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 1.5320976999999998 Count: 6 Min: 0.1486663 Max: 0.6729304
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:5
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:33:35.9665404Z, 2025-10-06T16:34:25.9604135Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 0.6624161 Count: 6 Min: 0.102408 Max: 0.1323369
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:6
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:33:35.9665404Z, 2025-10-06T16:34:25.9604135Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 2.9588364 Count: 10 Min: 0.2215412 Max: 0.5106006
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:3
(0.25,0.5]:6
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0


Metric Name: dotnet.gc.collections, Description: The number of garbage collections that have occurred since the process has started., Unit: {collection}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:34:25.9604136Z] gc.heap.generation: gen2
Value: 1
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:34:25.9604136Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:33:35.9665473Z, 2025-10-06T16:34:25.9604136Z] gc.heap.generation: gen0
Value: 2

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665548Z, 2025-10-06T16:34:25.9604138Z]
Value: 208629760

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665597Z, 2025-10-06T16:34:25.9604139Z]
Value: 50907872

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665650Z, 2025-10-06T16:34:25.9604140Z]
Value: 13565952

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:25.9604142Z] gc.heap.generation: gen0
Value: 0
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:25.9604142Z] gc.heap.generation: gen1
Value: 1042568
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:25.9604142Z] gc.heap.generation: gen2
Value: 3800856
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:25.9604142Z] gc.heap.generation: loh
Value: 3270784
(2025-10-06T16:33:35.9665712Z, 2025-10-06T16:34:25.9604142Z] gc.heap.generation: poh
Value: 58240

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:25.9604144Z] gc.heap.generation: gen0
Value: 0
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:25.9604144Z] gc.heap.generation: gen1
Value: 602336
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:25.9604144Z] gc.heap.generation: gen2
Value: 176104
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:25.9604144Z] gc.heap.generation: loh
Value: 736
(2025-10-06T16:33:35.9700709Z, 2025-10-06T16:34:25.9604144Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701062Z, 2025-10-06T16:34:25.9604145Z]
Value: 0.014596

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701174Z, 2025-10-06T16:34:25.9604146Z]
Value: 2336179

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701251Z, 2025-10-06T16:34:25.9604148Z]
Value: 30034

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701358Z, 2025-10-06T16:34:25.9604149Z]
Value: 6.7128693

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701429Z, 2025-10-06T16:34:25.9604152Z]
Value: 3

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701527Z, 2025-10-06T16:34:25.9604153Z]
Value: 6

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701694Z, 2025-10-06T16:34:25.9604155Z]
Value: 1224

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701765Z, 2025-10-06T16:34:25.9604156Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701834Z, 2025-10-06T16:34:25.9604157Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701915Z, 2025-10-06T16:34:25.9604161Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9701984Z, 2025-10-06T16:34:25.9604164Z] error.type: NotSupportedException
Value: 132

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9702055Z, 2025-10-06T16:34:25.9604165Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:33:35.9702132Z, 2025-10-06T16:34:25.9604166Z] cpu.mode: user
Value: 6.5
(2025-10-06T16:33:35.9702132Z, 2025-10-06T16:34:25.9604166Z] cpu.mode: system
Value: 0.875

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:33:36.0222280Z, 2025-10-06T16:34:25.9604169Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 6
(2025-10-06T16:33:36.0222280Z, 2025-10-06T16:34:25.9604169Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 6
(2025-10-06T16:33:36.0222280Z, 2025-10-06T16:34:25.9604169Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 10

Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Wayne Enterprises-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Stark Industries-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Themyscira Inc-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Daily Bugle-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Daily Planet-2025-10-06-12-34-08 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Wayne Enterprises-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Stark Industries-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Themyscira Inc-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Daily Bugle-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
(2025-10-06T16:34:08.3000691Z, 2025-10-06T16:34:25.9604176Z] company: Daily Planet-2025-10-06-12-34-13 has.email: true has.phone: true
Value: 1
