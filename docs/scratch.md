Value: 43

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2314202Z, 2025-10-06T16:08:42.3844558Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 2

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319220Z, 2025-10-06T16:08:42.3844564Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 20.8724303 Count: 100 Min: 0.102547 Max: 0.5102465
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:54
(0.2,0.5]:45
(0.5,1]:1
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
(2025-10-06T16:06:22.2319440Z, 2025-10-06T16:08:42.3844571Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319488Z, 2025-10-06T16:08:42.3844575Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319704Z, 2025-10-06T16:08:42.3844590Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.6382171 Count: 102 Min: 0.004882 Max: 0.0097009
(-Infinity,0.005]:1
(0.005,0.01]:101
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
(2025-10-06T16:06:22.2319765Z, 2025-10-06T16:08:42.3844594Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: dns.lookup.duration, Description: Measures the time taken to perform a DNS lookup., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.NameResolution
(2025-10-06T16:06:22.2319902Z, 2025-10-06T16:08:42.3844601Z] dns.question.name: localhost
Value: Sum: 0.0009794 Count: 1 Min: 0.0009794 Max: 0.0009794
(-Infinity,0.005]:1
(0.005,0.01]:0
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


Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:08:42.3844605Z] http.request.method: GET url.scheme: https
Value: 0
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:08:42.3844605Z] http.request.method: POST url.scheme: https
Value: 1

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:42.3844619Z] http.request.method: GET http.response.status_code: 200 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 0.7438393 Count: 1 Min: 0.7438393 Max: 0.7438393
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:42.3844619Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 4.265595 Count: 28 Min: 0.1306918 Max: 0.3812473
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:27
(0.25,0.5]:1
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:42.3844619Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 2.8709640999999997 Count: 27 Min: 0.0941098 Max: 0.1294205
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:3
(0.1,0.25]:24
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:42.3844619Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 12.8168761 Count: 45 Min: 0.2169108 Max: 0.5009659
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:8
(0.25,0.5]:36
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
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:08:42.3844621Z] gc.heap.generation: gen2
Value: 2
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:08:42.3844621Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:08:42.3844621Z] gc.heap.generation: gen0
Value: 3

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320147Z, 2025-10-06T16:08:42.3844623Z]
Value: 235573248

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320198Z, 2025-10-06T16:08:42.3844625Z]
Value: 101476544

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320260Z, 2025-10-06T16:08:42.3844626Z]
Value: 51666944

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:42.3844627Z] gc.heap.generation: gen0
Value: 1774392
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:42.3844627Z] gc.heap.generation: gen1
Value: 7071360
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:42.3844627Z] gc.heap.generation: gen2
Value: 3900296
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:42.3844627Z] gc.heap.generation: loh
Value: 6731584
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:42.3844627Z] gc.heap.generation: poh
Value: 362560

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:42.3844629Z] gc.heap.generation: gen0
Value: 1774136
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:42.3844629Z] gc.heap.generation: gen1
Value: 102832
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:42.3844629Z] gc.heap.generation: gen2
Value: 4616
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:42.3844629Z] gc.heap.generation: loh
Value: 1504
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:42.3844629Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380009Z, 2025-10-06T16:08:42.3844632Z]
Value: 0.042042

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380373Z, 2025-10-06T16:08:42.3844633Z]
Value: 2883839

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388753Z, 2025-10-06T16:08:42.3844636Z]
Value: 36354

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388853Z, 2025-10-06T16:08:42.3844637Z]
Value: 10.1796348

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388918Z, 2025-10-06T16:08:42.3844639Z]
Value: 7

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389013Z, 2025-10-06T16:08:42.3844641Z]
Value: 6

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389083Z, 2025-10-06T16:08:42.3844642Z]
Value: 5404

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389144Z, 2025-10-06T16:08:42.3844644Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389195Z, 2025-10-06T16:08:42.3844645Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389248Z, 2025-10-06T16:08:42.3844647Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:08:42.3844649Z] error.type: NotSupportedException
Value: 612
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:08:42.3844649Z] error.type: IOException
Value: 1

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389347Z, 2025-10-06T16:08:42.3844651Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:08:42.3844655Z] cpu.mode: user
Value: 10.1875
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:08:42.3844655Z] cpu.mode: system
Value: 2.734375

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:08:42.3844658Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 46
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:08:42.3844658Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 29
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:08:42.3844658Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 27

Metric Name: http.client.active_requests, Description: Number of outbound HTTP requests that are currently active on the client., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7014081Z, 2025-10-06T16:08:42.3844664Z] http.request.method: GET server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.request.duration, Description: Duration of HTTP client requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7016785Z, 2025-10-06T16:08:42.3844669Z] http.request.method: GET http.response.status_code: 200 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0237139 Count: 1 Min: 0.0237139 Max: 0.0237139
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: http.client.open_connections, Description: Number of outbound HTTP connections that are currently active or idle on the client., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:08:42.3844673Z] http.connection.state: idle network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:08:42.3844673Z] http.connection.state: active network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.connection.duration, Description: The duration of successfully established outbound HTTP connections., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017565Z, 2025-10-06T16:08:42.3844679Z] network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 75.015 Count: 1 Min: 75.015 Max: 75.015
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:0
(0.2,0.5]:0
(0.5,1]:0
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:1
(120,300]:0
(300,+Infinity]:0


Metric Name: http.client.request.time_in_queue, Description: The amount of time requests spent on a queue waiting for an available connection., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017737Z, 2025-10-06T16:08:42.3844684Z] http.request.method: GET network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0120319 Count: 1 Min: 0.0120319 Max: 0.0120319
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Wayne Enterprises-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Stark Industries-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Themyscira Inc-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Bugle-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:42.3844691Z] company: Daily Planet-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
LogRecord.Timestamp:               2025-10-06T16:08:42.4241953Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.4259612Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.4273760Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:42.4402169Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 913ca3b1-3e3d-4c15-90fd-f7a90754b469
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:42.4536208Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 913ca3b1-3e3d-4c15-90fd-f7a90754b469
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.4944091Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  67854810dbb15556
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (38ms) [Parameters=[@ToLower='?'], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE lower(t."Name") = @ToLower
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 38
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
[Scope.0]:SpanId: 67854810dbb15556
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: b286de6abb965999
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 913ca3b1-3e3d-4c15-90fd-f7a90754b469
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e8510df7ff356ab6d6829314d22dc4c9
Activity.SpanId:             67854810dbb15556
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       b286de6abb965999
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:42.4559091Z
Activity.Duration:           00:00:00.0404058
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5303058Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  f228a787480dd075
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
[Scope.0]:SpanId: f228a787480dd075
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: b286de6abb965999
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 913ca3b1-3e3d-4c15-90fd-f7a90754b469
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e8510df7ff356ab6d6829314d22dc4c9
Activity.SpanId:             f228a787480dd075
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       b286de6abb965999
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:42.4973669Z
Activity.Duration:           00:00:00.0350540
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5332816Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 77.815ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 77.815
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 913ca3b1-3e3d-4c15-90fd-f7a90754b469
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5346738Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags
[Scope.3]:ActionId: 913ca3b1-3e3d-4c15-90fd-f7a90754b469
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5360072Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api) in 83.0515ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.TagsController.CreateTag (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 83.0515
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5375057Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            e8510df7ff356ab6d6829314d22dc4c9
Activity.SpanId:             b286de6abb965999
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:42.4241759Z
Activity.Duration:           00:00:00.1364302
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5616233Z
LogRecord.TraceId:                 e8510df7ff356ab6d6829314d22dc4c9
LogRecord.SpanId:                  b286de6abb965999
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Tags - 201 - application/json;+charset=utf-8 137.4570ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 137.457
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
[Scope.0]:SpanId: b286de6abb965999
[Scope.0]:TraceId: e8510df7ff356ab6d6829314d22dc4c9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PAV
[Scope.2]:RequestId: 0HNG4U9GD5PAV:00000001
[Scope.2]:RequestPath: /api/Tags

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.5996421Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6025038Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6038038Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:42.6181146Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:42.6299359Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6680327Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  25ab25cdf1397f99
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (35ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 35
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
[Scope.0]:SpanId: 25ab25cdf1397f99
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 482d530b315ecddb
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            753fc0a4c2764726694096d5bce53b47
Activity.SpanId:             25ab25cdf1397f99
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       482d530b315ecddb
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:42.6325924Z
Activity.Duration:           00:00:00.0375450
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6716373Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 39.3283ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 39.3283
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6739087Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6753714Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) in 45.5809ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 45.5809
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.6769337Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            753fc0a4c2764726694096d5bce53b47
Activity.SpanId:             482d530b315ecddb
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:42.5996224Z
Activity.Duration:           00:00:00.0995313
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.7002538Z
LogRecord.TraceId:                 753fc0a4c2764726694096d5bce53b47
LogRecord.SpanId:                  482d530b315ecddb
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Groups - 201 - application/json;+charset=utf-8 100.6403ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 100.6403
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
[Scope.0]:SpanId: 482d530b315ecddb
[Scope.0]:TraceId: 753fc0a4c2764726694096d5bce53b47
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB0
[Scope.2]:RequestId: 0HNG4U9GD5PB0:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.7351699Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.7370286Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.7384626Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:42.7516867Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:42.7638422Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8055735Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  c64933b41b137e6b
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (38ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?' (DbType = DateTime), @p2='?', @p3='?'], CommandType='Text', CommandTimeout='30']
INSERT INTO "Groups" ("Id", "CreatedAt", "Description", "Name")
VALUES (@p0, @p1, @p2, @p3);
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 38
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
[Scope.0]:SpanId: c64933b41b137e6b
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: a2b311f0c5ec74f2
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            bcc9d479481db6d91d94e44c6856f28f
Activity.SpanId:             c64933b41b137e6b
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       a2b311f0c5ec74f2
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:42.7670999Z
Activity.Duration:           00:00:00.0402441
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8081560Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 41.583ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 41.583
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8094850Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8109928Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) in 47.2933ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 47.2933
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8123838Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            bcc9d479481db6d91d94e44c6856f28f
Activity.SpanId:             a2b311f0c5ec74f2
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:42.7351362Z
Activity.Duration:           00:00:00.0989965
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8352610Z
LogRecord.TraceId:                 bcc9d479481db6d91d94e44c6856f28f
LogRecord.SpanId:                  a2b311f0c5ec74f2
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Groups - 201 - application/json;+charset=utf-8 100.1437ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 100.1437
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
[Scope.0]:SpanId: a2b311f0c5ec74f2
[Scope.0]:TraceId: bcc9d479481db6d91d94e44c6856f28f
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB1
[Scope.2]:RequestId: 0HNG4U9GD5PB1:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8708239Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8727754Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.8740440Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:42.8862610Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:42.9006958Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.9336507Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  9ede5c0c9d2d4f0d
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
[Scope.0]:SpanId: 9ede5c0c9d2d4f0d
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 40512990c36ee1a3
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            7f9324f9831052ea4a920c7fb4ab2fff
Activity.SpanId:             9ede5c0c9d2d4f0d
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       40512990c36ee1a3
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:42.9026900Z
Activity.Duration:           00:00:00.0331612
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.9366809Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 34.3132ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 34.3132
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.9381056Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups
[Scope.3]:ActionId: e046cd7e-d9d9-4133-a436-0f0d8bfdd0df
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.9396354Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api) in 39.1019ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.GroupsController.CreateGroup (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 39.1019
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.9410907Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            7f9324f9831052ea4a920c7fb4ab2fff
Activity.SpanId:             40512990c36ee1a3
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:42.8708032Z
Activity.Duration:           00:00:00.0924045
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:42.9642223Z
LogRecord.TraceId:                 7f9324f9831052ea4a920c7fb4ab2fff
LogRecord.SpanId:                  40512990c36ee1a3
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Groups - 201 - application/json;+charset=utf-8 93.4284ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 93.4284
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
[Scope.0]:SpanId: 40512990c36ee1a3
[Scope.0]:TraceId: 7f9324f9831052ea4a920c7fb4ab2fff
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB2
[Scope.2]:RequestId: 0HNG4U9GD5PB2:00000001
[Scope.2]:RequestPath: /api/Groups

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.0013684Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.0033116Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.0047708Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:43.0196033Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:43.0329344Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.0346101Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  783831b03e8a08f6
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Adam-2025-10-06-12-08-44 West-2025-10-06-12-08-44
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Adam-2025-10-06-12-08-44
    LastName: West-2025-10-06-12-08-44
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 783831b03e8a08f6
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: d5f6956d8c5015af
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.0705682Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  8453c60026db5ef6
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
[Scope.0]:SpanId: 8453c60026db5ef6
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 783831b03e8a08f6
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             8453c60026db5ef6
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       783831b03e8a08f6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.0365974Z
Activity.Duration:           00:00:00.0357397
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.1107701Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  882d01b3746b9145
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
[Scope.0]:SpanId: 882d01b3746b9145
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 783831b03e8a08f6
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             882d01b3746b9145
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       783831b03e8a08f6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.0736384Z
Activity.Duration:           00:00:00.0393938
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.1496690Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  c892f5717d8c3daf
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
[Scope.0]:SpanId: c892f5717d8c3daf
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 783831b03e8a08f6
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             c892f5717d8c3daf
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       783831b03e8a08f6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.1144275Z
Activity.Duration:           00:00:00.0369658
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.1913564Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  69127429f0703b4b
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (39ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 39
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
[Scope.0]:SpanId: 69127429f0703b4b
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 783831b03e8a08f6
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             69127429f0703b4b
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       783831b03e8a08f6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.1526113Z
Activity.Duration:           00:00:00.0409250
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.2297276Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  1e3cd25137430ebc
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (35ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?', @p44='?' (DbType = Boolean), @p45='?', @p46='?' (DbType = Guid), @p47='?' (DbType = Guid), @p48='?', @p49='?' (DbType = Boolean), @p50='?', @p51='?' (DbType = Guid), @p52='?' (DbType = Guid), @p53='?' (DbType = Boolean), @p54='?', @p55='?', @p56='?' (DbType = Guid), @p57='?' (DbType = Guid), @p58='?' (DbType = Boolean), @p59='?', @p60='?'], CommandType='Text', CommandTimeout='30']
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
    elapsed: 35
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
[Scope.0]:SpanId: 1e3cd25137430ebc
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 783831b03e8a08f6
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             1e3cd25137430ebc
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       783831b03e8a08f6
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.1948571Z
Activity.Duration:           00:00:00.0378452
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.2706541Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  783831b03e8a08f6
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: 3ad1c4e2-5cd2-4516-8fb1-053518061ad4
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: 3ad1c4e2-5cd2-4516-8fb1-053518061ad4
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 783831b03e8a08f6
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: d5f6956d8c5015af
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             783831b03e8a08f6
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       d5f6956d8c5015af
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:08:43.0346018Z
Activity.Duration:           00:00:00.2378550
Activity.Tags:
    contact.id: 3ad1c4e2-5cd2-4516-8fb1-053518061ad4
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.2732454Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 238.6489ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 238.6489
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.2750524Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.2765642Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 243.8701ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 243.8701
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.2779941Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            70b72ede937343156815ff7b8133e558
Activity.SpanId:             d5f6956d8c5015af
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:43.0013466Z
Activity.Duration:           00:00:00.2988428
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.3014310Z
LogRecord.TraceId:                 70b72ede937343156815ff7b8133e558
LogRecord.SpanId:                  d5f6956d8c5015af
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 300.0958ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 300.0958
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
[Scope.0]:SpanId: d5f6956d8c5015af
[Scope.0]:TraceId: 70b72ede937343156815ff7b8133e558
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB3
[Scope.2]:RequestId: 0HNG4U9GD5PB3:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.3378743Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.3397066Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.3409670Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:43.3542953Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:43.3690733Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.3709651Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  8030976ad2e7b004
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Bruce-2025-10-06-12-08-44 Banner-2025-10-06-12-08-44
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Bruce-2025-10-06-12-08-44
    LastName: Banner-2025-10-06-12-08-44
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 8030976ad2e7b004
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 967a3e68d56ad463
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.4057479Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  e2a30dcade98aabd
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (33ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT g."Id", g."CreatedAt", g."Description", g."Name"
FROM "Groups" AS g
WHERE g."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 33
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
[Scope.0]:SpanId: e2a30dcade98aabd
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 8030976ad2e7b004
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f41c0710ba986e8d9ac85e77c43d68ae
Activity.SpanId:             e2a30dcade98aabd
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       8030976ad2e7b004
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.3730670Z
Activity.Duration:           00:00:00.0347026
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.4451100Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  f2b850b2e7ba4946
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
[Scope.0]:SpanId: f2b850b2e7ba4946
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 8030976ad2e7b004
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f41c0710ba986e8d9ac85e77c43d68ae
Activity.SpanId:             f2b850b2e7ba4946
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       8030976ad2e7b004
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.4090282Z
Activity.Duration:           00:00:00.0383545
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.4848066Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  63704527bcde44a2
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
[Scope.0]:SpanId: 63704527bcde44a2
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 8030976ad2e7b004
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f41c0710ba986e8d9ac85e77c43d68ae
Activity.SpanId:             63704527bcde44a2
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       8030976ad2e7b004
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.4485212Z
Activity.Duration:           00:00:00.0382893
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5258444Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  1a04075f1f00d196
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (38ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = Guid), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?', @p41='?' (DbType = Boolean), @p42='?', @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?' (DbType = Boolean), @p51='?', @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?'], CommandType='Text', CommandTimeout='30']
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
    elapsed: 38
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
[Scope.0]:SpanId: 1a04075f1f00d196
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 8030976ad2e7b004
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f41c0710ba986e8d9ac85e77c43d68ae
Activity.SpanId:             1a04075f1f00d196
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       8030976ad2e7b004
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.4882138Z
Activity.Duration:           00:00:00.0407467
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5636590Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  8030976ad2e7b004
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: c4a07165-a57e-4a9c-92bd-eba3f1242538
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: c4a07165-a57e-4a9c-92bd-eba3f1242538
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 8030976ad2e7b004
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 967a3e68d56ad463
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            f41c0710ba986e8d9ac85e77c43d68ae
Activity.SpanId:             8030976ad2e7b004
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       967a3e68d56ad463
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:08:43.3709564Z
Activity.Duration:           00:00:00.1944628
Activity.Tags:
    contact.id: c4a07165-a57e-4a9c-92bd-eba3f1242538
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5660797Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 195.1281ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 195.1281
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5674907Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5689089Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 200.0647ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 200.0647
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5702252Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            f41c0710ba986e8d9ac85e77c43d68ae
Activity.SpanId:             967a3e68d56ad463
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:43.3378537Z
Activity.Duration:           00:00:00.2531491
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.5921127Z
LogRecord.TraceId:                 f41c0710ba986e8d9ac85e77c43d68ae
LogRecord.SpanId:                  967a3e68d56ad463
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 254.2696ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 254.2696
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
[Scope.0]:SpanId: 967a3e68d56ad463
[Scope.0]:TraceId: f41c0710ba986e8d9ac85e77c43d68ae
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB4
[Scope.2]:RequestId: 0HNG4U9GD5PB4:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.6268610Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.6286623Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.6299828Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:43.6433746Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:43.6561779Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.6579167Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  5c98eb06192df6e8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Diana-2025-10-06-12-08-44 Prince-2025-10-06-12-08-44
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Diana-2025-10-06-12-08-44
    LastName: Prince-2025-10-06-12-08-44
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 5c98eb06192df6e8
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: aca0d36d0d792f5c
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.6907456Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  dca6e47a07b912e1
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
[Scope.0]:SpanId: dca6e47a07b912e1
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 5c98eb06192df6e8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a3fe30c729294a516c7b986ae45311a9
Activity.SpanId:             dca6e47a07b912e1
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       5c98eb06192df6e8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.6599336Z
Activity.Duration:           00:00:00.0329093
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.7306396Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  0f51e6b91539ad65
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
[Scope.0]:SpanId: 0f51e6b91539ad65
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 5c98eb06192df6e8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a3fe30c729294a516c7b986ae45311a9
Activity.SpanId:             0f51e6b91539ad65
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       5c98eb06192df6e8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.6941038Z
Activity.Duration:           00:00:00.0383658
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.7745518Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  a198ca7e067335d0
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (40ms) [Parameters=[@p='?' (DbType = Guid)], CommandType='Text', CommandTimeout='30']
SELECT t."Id", t."ColorHex", t."Name"
FROM "Tags" AS t
WHERE t."Id" = @p
LIMIT 1
LogRecord.Body:                    Executed DbCommand ({elapsed}ms) [Parameters=[{parameters}], CommandType='{commandType}', CommandTimeout='{commandTimeout}']{newLine}{commandText}
LogRecord.Attributes (Key:Value):
    elapsed: 40
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
[Scope.0]:SpanId: a198ca7e067335d0
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 5c98eb06192df6e8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a3fe30c729294a516c7b986ae45311a9
Activity.SpanId:             a198ca7e067335d0
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       5c98eb06192df6e8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.7340397Z
Activity.Duration:           00:00:00.0422219
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8123056Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  cf43178bb19cfb54
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (35ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?', @p42='?' (DbType = Boolean), @p43='?', @p44='?' (DbType = Guid), @p45='?' (DbType = Guid), @p46='?', @p47='?' (DbType = Boolean), @p48='?', @p49='?' (DbType = Guid), @p50='?' (DbType = Guid), @p51='?' (DbType = Boolean), @p52='?', @p53='?', @p54='?' (DbType = Guid), @p55='?' (DbType = Guid), @p56='?' (DbType = Boolean), @p57='?', @p58='?'], CommandType='Text', CommandTimeout='30']
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
    elapsed: 35
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
[Scope.0]:SpanId: cf43178bb19cfb54
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 5c98eb06192df6e8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a3fe30c729294a516c7b986ae45311a9
Activity.SpanId:             cf43178bb19cfb54
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       5c98eb06192df6e8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.7775954Z
Activity.Duration:           00:00:00.0378864
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8497413Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  5c98eb06192df6e8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: 7a0eedba-8bd6-48a2-a067-1192394f48bd
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: 7a0eedba-8bd6-48a2-a067-1192394f48bd
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 5c98eb06192df6e8
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: aca0d36d0d792f5c
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a3fe30c729294a516c7b986ae45311a9
Activity.SpanId:             5c98eb06192df6e8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       aca0d36d0d792f5c
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:08:43.6579099Z
Activity.Duration:           00:00:00.1939043
Activity.Tags:
    contact.id: 7a0eedba-8bd6-48a2-a067-1192394f48bd
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8526013Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 194.6965ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 194.6965
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8544628Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8559754Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 200.02ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 200.02
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8574381Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            a3fe30c729294a516c7b986ae45311a9
Activity.SpanId:             aca0d36d0d792f5c
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:43.6268402Z
Activity.Duration:           00:00:00.2529608
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.8809106Z
LogRecord.TraceId:                 a3fe30c729294a516c7b986ae45311a9
LogRecord.SpanId:                  aca0d36d0d792f5c
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 254.0802ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 254.0802
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
[Scope.0]:SpanId: aca0d36d0d792f5c
[Scope.0]:TraceId: a3fe30c729294a516c7b986ae45311a9
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB5
[Scope.2]:RequestId: 0HNG4U9GD5PB5:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.9165079Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.9184545Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.9198816Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:43.9341133Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:43.9461672Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.9478839Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  46468682f6a4bbfd
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Peter-2025-10-06-12-08-44 Parker-2025-10-06-12-08-44
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Peter-2025-10-06-12-08-44
    LastName: Parker-2025-10-06-12-08-44
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 46468682f6a4bbfd
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 4a73dd73c6d5394e
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:43.9867571Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4f12ddd364363648
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
[Scope.0]:SpanId: 4f12ddd364363648
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 46468682f6a4bbfd
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e5867c200e9efbdea933411eaac17298
Activity.SpanId:             4f12ddd364363648
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       46468682f6a4bbfd
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.9499456Z
Activity.Duration:           00:00:00.0387799
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.0252863Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  194641ce42ecd6a5
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
[Scope.0]:SpanId: 194641ce42ecd6a5
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 46468682f6a4bbfd
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e5867c200e9efbdea933411eaac17298
Activity.SpanId:             194641ce42ecd6a5
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       46468682f6a4bbfd
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:43.9899170Z
Activity.Duration:           00:00:00.0371264
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.0667857Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4933bab0542b2d2e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (39ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = Guid), @p37='?' (DbType = Guid), @p38='?', @p39='?' (DbType = Boolean), @p40='?', @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?', @p44='?' (DbType = Boolean), @p45='?', @p46='?' (DbType = Guid), @p47='?' (DbType = Guid), @p48='?' (DbType = Boolean), @p49='?', @p50='?', @p51='?' (DbType = Guid), @p52='?' (DbType = Guid), @p53='?' (DbType = Boolean), @p54='?', @p55='?'], CommandType='Text', CommandTimeout='30']
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
    elapsed: 39
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
[Scope.0]:SpanId: 4933bab0542b2d2e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 46468682f6a4bbfd
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e5867c200e9efbdea933411eaac17298
Activity.SpanId:             4933bab0542b2d2e
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       46468682f6a4bbfd
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.0282103Z
Activity.Duration:           00:00:00.0414999
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1054230Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  46468682f6a4bbfd
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: 9b22f848-16db-4875-b879-95041cbb68d0
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: 9b22f848-16db-4875-b879-95041cbb68d0
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 46468682f6a4bbfd
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 4a73dd73c6d5394e
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            e5867c200e9efbdea933411eaac17298
Activity.SpanId:             46468682f6a4bbfd
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       4a73dd73c6d5394e
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:08:43.9478761Z
Activity.Duration:           00:00:00.1593440
Activity.Tags:
    contact.id: 9b22f848-16db-4875-b879-95041cbb68d0
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1079129Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 160.0413ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 160.0413
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1104973Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1122532Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 166.315ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 166.315
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1138026Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            e5867c200e9efbdea933411eaac17298
Activity.SpanId:             4a73dd73c6d5394e
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:43.9164871Z
Activity.Duration:           00:00:00.2177719
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1352892Z
LogRecord.TraceId:                 e5867c200e9efbdea933411eaac17298
LogRecord.SpanId:                  4a73dd73c6d5394e
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 218.8111ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 218.8111
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
[Scope.0]:SpanId: 4a73dd73c6d5394e
[Scope.0]:TraceId: e5867c200e9efbdea933411eaac17298
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB6
[Scope.2]:RequestId: 0HNG4U9GD5PB6:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1713748Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1740907Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.1755112Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
LogRecord.Timestamp:               2025-10-06T16:08:44.1885349Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.Reflection.RuntimeMethodInfo' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.
LogRecord.Timestamp:               2025-10-06T16:08:44.2007331Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.2021716Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  3dfcbbe5da8068f8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Creating new contact: Clark-2025-10-06-12-08-44 Kent-2025-10-06-12-08-44
LogRecord.Body:                    Creating new contact: {FirstName} {LastName}
LogRecord.Attributes (Key:Value):
    FirstName: Clark-2025-10-06-12-08-44
    LastName: Kent-2025-10-06-12-08-44
    OriginalFormat (a.k.a Body): Creating new contact: {FirstName} {LastName}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3dfcbbe5da8068f8
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 727f309db337d189
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.2420860Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  dce968b771db9e73
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
[Scope.0]:SpanId: dce968b771db9e73
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 3dfcbbe5da8068f8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             dce968b771db9e73
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3dfcbbe5da8068f8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.2052239Z
Activity.Duration:           00:00:00.0389591
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.2812940Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  1591d52a766c03d8
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
[Scope.0]:SpanId: 1591d52a766c03d8
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 3dfcbbe5da8068f8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             1591d52a766c03d8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3dfcbbe5da8068f8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.2455497Z
Activity.Duration:           00:00:00.0378656
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.3212994Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  56c29ab1077473bd
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
[Scope.0]:SpanId: 56c29ab1077473bd
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 3dfcbbe5da8068f8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             56c29ab1077473bd
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3dfcbbe5da8068f8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.2846932Z
Activity.Duration:           00:00:00.0384604
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.3606236Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  cbd8a28de931abf1
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
[Scope.0]:SpanId: cbd8a28de931abf1
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 3dfcbbe5da8068f8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             cbd8a28de931abf1
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3dfcbbe5da8068f8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.3241977Z
Activity.Duration:           00:00:00.0385351
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.3997629Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  943d1f41fa81d741
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
[Scope.0]:SpanId: 943d1f41fa81d741
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 3dfcbbe5da8068f8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             943d1f41fa81d741
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3dfcbbe5da8068f8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.3638319Z
Activity.Duration:           00:00:00.0381619
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.4413070Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  80a43c306f7d4bf8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.EntityFrameworkCore.Database.Command
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed DbCommand (38ms) [Parameters=[@p0='?' (DbType = Guid), @p1='?', @p2='?' (DbType = DateTime), @p3='?' (DbType = DateTime), @p4='?', @p5='?', @p6='?', @p7='?', @p8='?', @p9='?', @p10='?' (DbType = DateTime), @p11='?' (DbType = Guid), @p12='?', @p13='?' (DbType = Guid), @p14='?', @p15='?' (DbType = Boolean), @p16='?', @p17='?', @p18='?', @p19='?', @p20='?', @p21='?' (DbType = Guid), @p22='?', @p23='?' (DbType = Guid), @p24='?', @p25='?' (DbType = Boolean), @p26='?', @p27='?', @p28='?', @p29='?', @p30='?', @p31='?' (DbType = Guid), @p32='?' (DbType = Guid), @p33='?' (DbType = DateTime), @p34='?' (DbType = Guid), @p35='?' (DbType = Guid), @p36='?' (DbType = DateTime), @p37='?' (DbType = Guid), @p38='?' (DbType = Guid), @p39='?' (DbType = Guid), @p40='?' (DbType = Guid), @p41='?' (DbType = Guid), @p42='?' (DbType = Guid), @p43='?' (DbType = Guid), @p44='?' (DbType = Guid), @p45='?', @p46='?' (DbType = Boolean), @p47='?', @p48='?' (DbType = Guid), @p49='?' (DbType = Guid), @p50='?', @p51='?' (DbType = Boolean), @p52='?', @p53='?' (DbType = Guid), @p54='?' (DbType = Guid), @p55='?' (DbType = Boolean), @p56='?', @p57='?', @p58='?' (DbType = Guid), @p59='?' (DbType = Guid), @p60='?' (DbType = Boolean), @p61='?', @p62='?'], CommandType='Text', CommandTimeout='30']
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
    elapsed: 38
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
[Scope.0]:SpanId: 80a43c306f7d4bf8
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 3dfcbbe5da8068f8
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             80a43c306f7d4bf8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       3dfcbbe5da8068f8
Activity.DisplayName:        neondb
Activity.Kind:               Client
Activity.StartTime:          2025-10-06T16:08:44.4033777Z
Activity.Duration:           00:00:00.0404255
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.4791044Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  3dfcbbe5da8068f8
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            MyOpenTelemetryApi.Application.Services.ContactService
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Contact created successfully: 721df59a-d715-4171-914a-ccd068010e35
LogRecord.Body:                    Contact created successfully: {ContactId}
LogRecord.Attributes (Key:Value):
    ContactId: 721df59a-d715-4171-914a-ccd068010e35
    OriginalFormat (a.k.a Body): Contact created successfully: {ContactId}
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 3dfcbbe5da8068f8
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 727f309db337d189
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             3dfcbbe5da8068f8
Activity.TraceFlags:         Recorded
Activity.ParentSpanId:       727f309db337d189
Activity.DisplayName:        CreateContact
Activity.Kind:               Internal
Activity.StartTime:          2025-10-06T16:08:44.2021638Z
Activity.Duration:           00:00:00.2785773
Activity.Tags:
    contact.id: 721df59a-d715-4171-914a-ccd068010e35
Instrumentation scope (ActivitySource):
    Name: Microsoft.AspNetCore
Resource associated with Activity:
    service.name: MyOpenTelemetryApi
    service.version: 1.0.0
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.4816447Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action method MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api), returned result Microsoft.AspNetCore.Mvc.CreatedAtActionResult in 279.4856ms.
LogRecord.Body:                    Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ActionResult: Microsoft.AspNetCore.Mvc.CreatedAtActionResult
    ElapsedMilliseconds: 279.4856
    OriginalFormat (a.k.a Body): Executed action method {ActionName}, returned result {ActionResult} in {ElapsedMilliseconds}ms.
LogRecord.EventId:                 103
LogRecord.EventName:               ActionMethodExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.4832039Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts
[Scope.3]:ActionId: 94387d09-4a12-4ce7-9d4d-ffc718a57991
[Scope.3]:ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.4858775Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Mvc.Infrastructure.ControllerActionInvoker
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Executed action MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api) in 285.3383ms
LogRecord.Body:                    Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ActionName: MyOpenTelemetryApi.Api.Controllers.ContactsController.CreateContact (MyOpenTelemetryApi.Api)
    ElapsedMilliseconds: 285.3383
    OriginalFormat (a.k.a Body): Executed action {ActionName} in {ElapsedMilliseconds}ms
LogRecord.EventId:                 105
LogRecord.EventName:               ActionExecuted
LogRecord.ScopeValues (Key:Value):
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.4875434Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Error exporting logs to file: Serialization and deserialization of 'System.RuntimeType' instances is not supported. The unsupported member type is located on type 'System.Object'. Path: $.Attributes.Metadata.TypeId.
Activity.TraceId:            a511c80ae51648c4f73a4a66f23d8c1e
Activity.SpanId:             727f309db337d189
Activity.TraceFlags:         Recorded
Activity.DisplayName:        POST
Activity.Kind:               Server
Activity.StartTime:          2025-10-06T16:08:44.1713487Z
Activity.Duration:           00:00:00.3397536
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
    service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
    telemetry.sdk.name: opentelemetry
    telemetry.sdk.language: dotnet
    telemetry.sdk.version: 1.13.0

LogRecord.Timestamp:               2025-10-06T16:08:44.5120902Z
LogRecord.TraceId:                 a511c80ae51648c4f73a4a66f23d8c1e
LogRecord.SpanId:                  727f309db337d189
LogRecord.TraceFlags:              Recorded
LogRecord.CategoryName:            Microsoft.AspNetCore.Hosting.Diagnostics
LogRecord.Severity:                Info
LogRecord.SeverityText:            Information
LogRecord.FormattedMessage:        Request finished HTTP/2 POST https://192.168.0.80:7034/api/Contacts - 201 - application/json;+charset=utf-8 340.7556ms
LogRecord.Body:                    Request finished {Protocol} {Method} {Scheme}://{Host}{PathBase}{Path}{QueryString} - {StatusCode} {ContentLength} {ContentType} {ElapsedMilliseconds}ms
LogRecord.Attributes (Key:Value):
    ElapsedMilliseconds: 340.7556
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
[Scope.0]:SpanId: 727f309db337d189
[Scope.0]:TraceId: a511c80ae51648c4f73a4a66f23d8c1e
[Scope.0]:ParentId: 0000000000000000
[Scope.1]:ConnectionId: 0HNG4U9GD5PB7
[Scope.2]:RequestId: 0HNG4U9GD5PB7:00000001
[Scope.2]:RequestPath: /api/Contacts

Resource associated with LogRecord:
service.name: MyOpenTelemetryApi
service.version: 1.0.0
service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
environment: Development
deployment.environment: Development
host.name: DESKTOP-3J5HTD8
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.13.0

Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2301911Z, 2025-10-06T16:08:52.2554441Z]
Value: 234958848

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2311886Z, 2025-10-06T16:08:52.2554445Z]
Value: 2481127288832

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:08:52.2554446Z] process.cpu.state: user
Value: 10.34375
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:08:52.2554446Z] process.cpu.state: system
Value: 2.96875

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314027Z, 2025-10-06T16:08:52.2554448Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314117Z, 2025-10-06T16:08:52.2554450Z]
Value: 43

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2314202Z, 2025-10-06T16:08:52.2554454Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 1

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319220Z, 2025-10-06T16:08:52.2554461Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 22.907633999999998 Count: 110 Min: 0.1023319 Max: 0.5102465
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:59
(0.2,0.5]:50
(0.5,1]:1
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
(2025-10-06T16:06:22.2319440Z, 2025-10-06T16:08:52.2554471Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319488Z, 2025-10-06T16:08:52.2554475Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319704Z, 2025-10-06T16:08:52.2554487Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.6948260999999999 Count: 111 Min: 0.004882 Max: 0.0097009
(-Infinity,0.005]:1
(0.005,0.01]:110
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
(2025-10-06T16:06:22.2319765Z, 2025-10-06T16:08:52.2554493Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: dns.lookup.duration, Description: Measures the time taken to perform a DNS lookup., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.NameResolution
(2025-10-06T16:06:22.2319902Z, 2025-10-06T16:08:52.2554500Z] dns.question.name: localhost
Value: Sum: 0.0009794 Count: 1 Min: 0.0009794 Max: 0.0009794
(-Infinity,0.005]:1
(0.005,0.01]:0
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


Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:08:52.2554504Z] http.request.method: GET url.scheme: https
Value: 0
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:08:52.2554504Z] http.request.method: POST url.scheme: https
Value: 0

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:52.2554517Z] http.request.method: GET http.response.status_code: 200 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 0.7438393 Count: 1 Min: 0.7438393 Max: 0.7438393
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:52.2554517Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 4.546734300000001 Count: 30 Min: 0.1306918 Max: 0.3812473
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:29
(0.25,0.5]:1
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:52.2554517Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 3.1651764999999994 Count: 30 Min: 0.0934284 Max: 0.1294205
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:4
(0.1,0.25]:26
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:08:52.2554517Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 14.1848884 Count: 50 Min: 0.2169108 Max: 0.5009659
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:9
(0.25,0.5]:40
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
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:08:52.2554518Z] gc.heap.generation: gen2
Value: 2
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:08:52.2554518Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:08:52.2554518Z] gc.heap.generation: gen0
Value: 4

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320147Z, 2025-10-06T16:08:52.2554519Z]
Value: 234958848

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320198Z, 2025-10-06T16:08:52.2554520Z]
Value: 107512208

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320260Z, 2025-10-06T16:08:52.2554522Z]
Value: 55922688

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: gen0
Value: 1774392
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: gen1
Value: 7071360
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: gen2
Value: 3900296
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: loh
Value: 6731584
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: poh
Value: 412000

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: gen0
Value: 1550288
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: gen1
Value: 102832
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: gen2
Value: 4616
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: loh
Value: 1504
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:08:52.2554523Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380009Z, 2025-10-06T16:08:52.2554526Z]
Value: 0.044872

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380373Z, 2025-10-06T16:08:52.2554527Z]
Value: 2885654

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388753Z, 2025-10-06T16:08:52.2554528Z]
Value: 36378

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388853Z, 2025-10-06T16:08:52.2554530Z]
Value: 10.1909638

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388918Z, 2025-10-06T16:08:52.2554531Z]
Value: 18

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389013Z, 2025-10-06T16:08:52.2554532Z]
Value: 6

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389083Z, 2025-10-06T16:08:52.2554533Z]
Value: 5899

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389144Z, 2025-10-06T16:08:52.2554535Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389195Z, 2025-10-06T16:08:52.2554536Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389248Z, 2025-10-06T16:08:52.2554538Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:08:52.2554541Z] error.type: NotSupportedException
Value: 666
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:08:52.2554541Z] error.type: IOException
Value: 1

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389347Z, 2025-10-06T16:08:52.2554543Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:08:52.2554545Z] cpu.mode: user
Value: 10.34375
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:08:52.2554545Z] cpu.mode: system
Value: 2.96875

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:08:52.2554551Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 51
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:08:52.2554551Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 30
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:08:52.2554551Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 30

Metric Name: http.client.active_requests, Description: Number of outbound HTTP requests that are currently active on the client., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7014081Z, 2025-10-06T16:08:52.2554559Z] http.request.method: GET server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.request.duration, Description: Duration of HTTP client requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7016785Z, 2025-10-06T16:08:52.2554564Z] http.request.method: GET http.response.status_code: 200 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0237139 Count: 1 Min: 0.0237139 Max: 0.0237139
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: http.client.open_connections, Description: Number of outbound HTTP connections that are currently active or idle on the client., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:08:52.2554569Z] http.connection.state: idle network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:08:52.2554569Z] http.connection.state: active network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.connection.duration, Description: The duration of successfully established outbound HTTP connections., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017565Z, 2025-10-06T16:08:52.2554575Z] network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 75.015 Count: 1 Min: 75.015 Max: 75.015
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:0
(0.2,0.5]:0
(0.5,1]:0
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:1
(120,300]:0
(300,+Infinity]:0


Metric Name: http.client.request.time_in_queue, Description: The amount of time requests spent on a queue waiting for an available connection., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017737Z, 2025-10-06T16:08:52.2554580Z] http.request.method: GET network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0120319 Count: 1 Min: 0.0120319 Max: 0.0120319
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Wayne Enterprises-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Stark Industries-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Themyscira Inc-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Bugle-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:08:52.2554588Z] company: Daily Planet-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2301911Z, 2025-10-06T16:09:02.2173628Z]
Value: 234913792

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2311886Z, 2025-10-06T16:09:02.2173635Z]
Value: 2481125650432

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:09:02.2173637Z] process.cpu.state: user
Value: 10.359375
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:09:02.2173637Z] process.cpu.state: system
Value: 3

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314027Z, 2025-10-06T16:09:02.2173640Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314117Z, 2025-10-06T16:09:02.2173641Z]
Value: 43

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2314202Z, 2025-10-06T16:09:02.2173643Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 1

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319220Z, 2025-10-06T16:09:02.2173650Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 22.907633999999998 Count: 110 Min: 0.1023319 Max: 0.5102465
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:59
(0.2,0.5]:50
(0.5,1]:1
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
(2025-10-06T16:06:22.2319440Z, 2025-10-06T16:09:02.2173657Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319488Z, 2025-10-06T16:09:02.2173659Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319704Z, 2025-10-06T16:09:02.2173669Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.6948260999999999 Count: 111 Min: 0.004882 Max: 0.0097009
(-Infinity,0.005]:1
(0.005,0.01]:110
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
(2025-10-06T16:06:22.2319765Z, 2025-10-06T16:09:02.2173672Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: dns.lookup.duration, Description: Measures the time taken to perform a DNS lookup., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.NameResolution
(2025-10-06T16:06:22.2319902Z, 2025-10-06T16:09:02.2173677Z] dns.question.name: localhost
Value: Sum: 0.0009794 Count: 1 Min: 0.0009794 Max: 0.0009794
(-Infinity,0.005]:1
(0.005,0.01]:0
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


Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:09:02.2173681Z] http.request.method: GET url.scheme: https
Value: 0
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:09:02.2173681Z] http.request.method: POST url.scheme: https
Value: 0

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:02.2173693Z] http.request.method: GET http.response.status_code: 200 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 0.7438393 Count: 1 Min: 0.7438393 Max: 0.7438393
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:02.2173693Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 4.546734300000001 Count: 30 Min: 0.1306918 Max: 0.3812473
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:29
(0.25,0.5]:1
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:02.2173693Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 3.1651764999999994 Count: 30 Min: 0.0934284 Max: 0.1294205
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:4
(0.1,0.25]:26
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:02.2173693Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 14.1848884 Count: 50 Min: 0.2169108 Max: 0.5009659
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:9
(0.25,0.5]:40
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
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:02.2173694Z] gc.heap.generation: gen2
Value: 2
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:02.2173694Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:02.2173694Z] gc.heap.generation: gen0
Value: 4

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320147Z, 2025-10-06T16:09:02.2173696Z]
Value: 234983424

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320198Z, 2025-10-06T16:09:02.2173697Z]
Value: 107999920

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320260Z, 2025-10-06T16:09:02.2173699Z]
Value: 55922688

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:02.2173700Z] gc.heap.generation: gen0
Value: 1774392
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:02.2173700Z] gc.heap.generation: gen1
Value: 7071360
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:02.2173700Z] gc.heap.generation: gen2
Value: 3900296
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:02.2173700Z] gc.heap.generation: loh
Value: 6731584
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:02.2173700Z] gc.heap.generation: poh
Value: 412000

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:02.2173702Z] gc.heap.generation: gen0
Value: 1550288
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:02.2173702Z] gc.heap.generation: gen1
Value: 102832
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:02.2173702Z] gc.heap.generation: gen2
Value: 4616
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:02.2173702Z] gc.heap.generation: loh
Value: 1504
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:02.2173702Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380009Z, 2025-10-06T16:09:02.2173704Z]
Value: 0.044872

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380373Z, 2025-10-06T16:09:02.2173706Z]
Value: 2886290

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388753Z, 2025-10-06T16:09:02.2173711Z]
Value: 36387

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388853Z, 2025-10-06T16:09:02.2173712Z]
Value: 10.2011495

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388918Z, 2025-10-06T16:09:02.2173713Z]
Value: 18

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389013Z, 2025-10-06T16:09:02.2173715Z]
Value: 6

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389083Z, 2025-10-06T16:09:02.2173716Z]
Value: 5939

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389144Z, 2025-10-06T16:09:02.2173719Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389195Z, 2025-10-06T16:09:02.2173720Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389248Z, 2025-10-06T16:09:02.2173721Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:09:02.2173724Z] error.type: NotSupportedException
Value: 666
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:09:02.2173724Z] error.type: IOException
Value: 1

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389347Z, 2025-10-06T16:09:02.2173725Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:09:02.2173727Z] cpu.mode: user
Value: 10.359375
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:09:02.2173727Z] cpu.mode: system
Value: 3.015625

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:02.2173730Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 51
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:02.2173730Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 30
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:02.2173730Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 30

Metric Name: http.client.active_requests, Description: Number of outbound HTTP requests that are currently active on the client., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7014081Z, 2025-10-06T16:09:02.2173734Z] http.request.method: GET server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.request.duration, Description: Duration of HTTP client requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7016785Z, 2025-10-06T16:09:02.2173738Z] http.request.method: GET http.response.status_code: 200 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0237139 Count: 1 Min: 0.0237139 Max: 0.0237139
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: http.client.open_connections, Description: Number of outbound HTTP connections that are currently active or idle on the client., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:09:02.2173741Z] http.connection.state: idle network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:09:02.2173741Z] http.connection.state: active network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.connection.duration, Description: The duration of successfully established outbound HTTP connections., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017565Z, 2025-10-06T16:09:02.2173746Z] network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 75.015 Count: 1 Min: 75.015 Max: 75.015
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:0
(0.2,0.5]:0
(0.5,1]:0
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:1
(120,300]:0
(300,+Infinity]:0


Metric Name: http.client.request.time_in_queue, Description: The amount of time requests spent on a queue waiting for an available connection., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017737Z, 2025-10-06T16:09:02.2173750Z] http.request.method: GET network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0120319 Count: 1 Min: 0.0120319 Max: 0.0120319
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Wayne Enterprises-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Stark Industries-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Themyscira Inc-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Bugle-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:02.2173756Z] company: Daily Planet-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2301911Z, 2025-10-06T16:09:12.2256058Z]
Value: 234962944

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2311886Z, 2025-10-06T16:09:12.2256064Z]
Value: 2481125715968

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:09:12.2256066Z] process.cpu.state: user
Value: 10.359375
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:09:12.2256066Z] process.cpu.state: system
Value: 3.03125

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314027Z, 2025-10-06T16:09:12.2256068Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314117Z, 2025-10-06T16:09:12.2256070Z]
Value: 42

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2314202Z, 2025-10-06T16:09:12.2256073Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 1

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319220Z, 2025-10-06T16:09:12.2256079Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 22.907633999999998 Count: 110 Min: 0.1023319 Max: 0.5102465
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:59
(0.2,0.5]:50
(0.5,1]:1
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
(2025-10-06T16:06:22.2319440Z, 2025-10-06T16:09:12.2256085Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319488Z, 2025-10-06T16:09:12.2256088Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319704Z, 2025-10-06T16:09:12.2256098Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.6948260999999999 Count: 111 Min: 0.004882 Max: 0.0097009
(-Infinity,0.005]:1
(0.005,0.01]:110
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
(2025-10-06T16:06:22.2319765Z, 2025-10-06T16:09:12.2256101Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: dns.lookup.duration, Description: Measures the time taken to perform a DNS lookup., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.NameResolution
(2025-10-06T16:06:22.2319902Z, 2025-10-06T16:09:12.2256107Z] dns.question.name: localhost
Value: Sum: 0.0009794 Count: 1 Min: 0.0009794 Max: 0.0009794
(-Infinity,0.005]:1
(0.005,0.01]:0
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


Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:09:12.2256111Z] http.request.method: GET url.scheme: https
Value: 0
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:09:12.2256111Z] http.request.method: POST url.scheme: https
Value: 0

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:12.2256127Z] http.request.method: GET http.response.status_code: 200 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 0.7438393 Count: 1 Min: 0.7438393 Max: 0.7438393
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:12.2256127Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 4.546734300000001 Count: 30 Min: 0.1306918 Max: 0.3812473
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:29
(0.25,0.5]:1
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:12.2256127Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 3.1651764999999994 Count: 30 Min: 0.0934284 Max: 0.1294205
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:4
(0.1,0.25]:26
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:12.2256127Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 14.1848884 Count: 50 Min: 0.2169108 Max: 0.5009659
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:9
(0.25,0.5]:40
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
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:12.2256128Z] gc.heap.generation: gen2
Value: 2
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:12.2256128Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:12.2256128Z] gc.heap.generation: gen0
Value: 4

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320147Z, 2025-10-06T16:09:12.2256130Z]
Value: 235298816

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320198Z, 2025-10-06T16:09:12.2256131Z]
Value: 108489728

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320260Z, 2025-10-06T16:09:12.2256132Z]
Value: 55922688

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:12.2256134Z] gc.heap.generation: gen0
Value: 1774392
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:12.2256134Z] gc.heap.generation: gen1
Value: 7071360
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:12.2256134Z] gc.heap.generation: gen2
Value: 3900296
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:12.2256134Z] gc.heap.generation: loh
Value: 6731584
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:12.2256134Z] gc.heap.generation: poh
Value: 412000

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:12.2256136Z] gc.heap.generation: gen0
Value: 1550288
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:12.2256136Z] gc.heap.generation: gen1
Value: 102832
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:12.2256136Z] gc.heap.generation: gen2
Value: 4616
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:12.2256136Z] gc.heap.generation: loh
Value: 1504
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:12.2256136Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380009Z, 2025-10-06T16:09:12.2256138Z]
Value: 0.044872

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380373Z, 2025-10-06T16:09:12.2256140Z]
Value: 2887610

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388753Z, 2025-10-06T16:09:12.2256145Z]
Value: 36403

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388853Z, 2025-10-06T16:09:12.2256146Z]
Value: 10.2043948

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388918Z, 2025-10-06T16:09:12.2256147Z]
Value: 18

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389013Z, 2025-10-06T16:09:12.2256149Z]
Value: 5

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389083Z, 2025-10-06T16:09:12.2256150Z]
Value: 5975

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389144Z, 2025-10-06T16:09:12.2256151Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389195Z, 2025-10-06T16:09:12.2256152Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389248Z, 2025-10-06T16:09:12.2256154Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:09:12.2256157Z] error.type: NotSupportedException
Value: 666
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:09:12.2256157Z] error.type: IOException
Value: 1

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389347Z, 2025-10-06T16:09:12.2256158Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:09:12.2256160Z] cpu.mode: user
Value: 10.359375
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:09:12.2256160Z] cpu.mode: system
Value: 3.03125

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:12.2256162Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 51
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:12.2256162Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 30
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:12.2256162Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 30

Metric Name: http.client.active_requests, Description: Number of outbound HTTP requests that are currently active on the client., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7014081Z, 2025-10-06T16:09:12.2256167Z] http.request.method: GET server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.request.duration, Description: Duration of HTTP client requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7016785Z, 2025-10-06T16:09:12.2256171Z] http.request.method: GET http.response.status_code: 200 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0237139 Count: 1 Min: 0.0237139 Max: 0.0237139
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: http.client.open_connections, Description: Number of outbound HTTP connections that are currently active or idle on the client., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:09:12.2256174Z] http.connection.state: idle network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:09:12.2256174Z] http.connection.state: active network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.connection.duration, Description: The duration of successfully established outbound HTTP connections., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017565Z, 2025-10-06T16:09:12.2256181Z] network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 75.015 Count: 1 Min: 75.015 Max: 75.015
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:0
(0.2,0.5]:0
(0.5,1]:0
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:1
(120,300]:0
(300,+Infinity]:0


Metric Name: http.client.request.time_in_queue, Description: The amount of time requests spent on a queue waiting for an available connection., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017737Z, 2025-10-06T16:09:12.2256184Z] http.request.method: GET network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0120319 Count: 1 Min: 0.0120319 Max: 0.0120319
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Wayne Enterprises-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Stark Industries-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Themyscira Inc-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Bugle-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:12.2256190Z] company: Daily Planet-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
Resource associated with Metrics:
        service.name: MyOpenTelemetryApi
        service.version: 1.0.0
        service.instance.id: 92f51fb3-e090-4055-9115-d171cfd7f574
        telemetry.sdk.name: opentelemetry
        telemetry.sdk.language: dotnet
        telemetry.sdk.version: 1.13.0

Metric Name: process.memory.usage, Description: The amount of physical memory in use., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2301911Z, 2025-10-06T16:09:22.2222394Z]
Value: 235257856

Metric Name: process.memory.virtual, Description: The amount of committed virtual memory., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2311886Z, 2025-10-06T16:09:22.2222399Z]
Value: 2481122570240

Metric Name: process.cpu.time, Description: Total CPU seconds broken down by different states., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:09:22.2222402Z] process.cpu.state: user
Value: 10.421875
(2025-10-06T16:06:22.2313849Z, 2025-10-06T16:09:22.2222402Z] process.cpu.state: system
Value: 3.0625

Metric Name: process.cpu.count, Description: The number of processors (CPU cores) available to the current process., Unit: {processors}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314027Z, 2025-10-06T16:09:22.2222404Z]
Value: 12

Metric Name: process.thread.count, Description: Process threads count., Unit: {thread}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: OpenTelemetry.Instrumentation.Process
        Version: 1.12.0-beta.1
(2025-10-06T16:06:22.2314117Z, 2025-10-06T16:09:22.2222406Z]
Value: 40

Metric Name: kestrel.active_connections, Description: Number of connections that are currently active on the server., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2314202Z, 2025-10-06T16:09:22.2222409Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 1

Metric Name: kestrel.connection.duration, Description: The duration of connections on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319220Z, 2025-10-06T16:09:22.2222415Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 22.907633999999998 Count: 110 Min: 0.1023319 Max: 0.5102465
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:59
(0.2,0.5]:50
(0.5,1]:1
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
(2025-10-06T16:06:22.2319440Z, 2025-10-06T16:09:22.2222423Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.queued_requests, Description: Number of HTTP requests on multiplexed connections (HTTP/2 and HTTP/3) that are currently queued and are waiting to start., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319488Z, 2025-10-06T16:09:22.2222426Z] network.protocol.name: http network.protocol.version: 2 network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: kestrel.tls_handshake.duration, Description: The duration of TLS handshakes on the server., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Server.Kestrel
(2025-10-06T16:06:22.2319704Z, 2025-10-06T16:09:22.2222436Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034 tls.protocol.version: 1.3
Value: Sum: 0.6948260999999999 Count: 111 Min: 0.004882 Max: 0.0097009
(-Infinity,0.005]:1
(0.005,0.01]:110
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
(2025-10-06T16:06:22.2319765Z, 2025-10-06T16:09:22.2222443Z] network.transport: tcp network.type: ipv4 server.address: 192.168.0.80 server.port: 7034
Value: 0

Metric Name: dns.lookup.duration, Description: Measures the time taken to perform a DNS lookup., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.NameResolution
(2025-10-06T16:06:22.2319902Z, 2025-10-06T16:09:22.2222449Z] dns.question.name: localhost
Value: Sum: 0.0009794 Count: 1 Min: 0.0009794 Max: 0.0009794
(-Infinity,0.005]:1
(0.005,0.01]:0
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


Metric Name: http.server.active_requests, Description: Number of active HTTP server requests., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:09:22.2222452Z] http.request.method: GET url.scheme: https
Value: 0
(2025-10-06T16:06:22.2319965Z, 2025-10-06T16:09:22.2222452Z] http.request.method: POST url.scheme: https
Value: 0

Metric Name: http.server.request.duration, Description: Duration of HTTP server requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Hosting
(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:22.2222465Z] http.request.method: GET http.response.status_code: 200 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 0.7438393 Count: 1 Min: 0.7438393 Max: 0.7438393
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:0
(0.25,0.5]:0
(0.5,0.75]:1
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:22.2222465Z] http.request.method: POST http.response.status_code: 201 http.route: api/Tags network.protocol.version: 2 url.scheme: https
Value: Sum: 4.546734300000001 Count: 30 Min: 0.1306918 Max: 0.3812473
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:29
(0.25,0.5]:1
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:22.2222465Z] http.request.method: POST http.response.status_code: 201 http.route: api/Groups network.protocol.version: 2 url.scheme: https
Value: Sum: 3.1651764999999994 Count: 30 Min: 0.0934284 Max: 0.1294205
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:4
(0.1,0.25]:26
(0.25,0.5]:0
(0.5,0.75]:0
(0.75,1]:0
(1,2.5]:0
(2.5,5]:0
(5,7.5]:0
(7.5,10]:0
(10,+Infinity]:0

(2025-10-06T16:06:22.2320030Z, 2025-10-06T16:09:22.2222465Z] http.request.method: POST http.response.status_code: 201 http.route: api/Contacts network.protocol.version: 2 url.scheme: https
Value: Sum: 14.1848884 Count: 50 Min: 0.2169108 Max: 0.5009659
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:0
(0.025,0.05]:0
(0.05,0.075]:0
(0.075,0.1]:0
(0.1,0.25]:9
(0.25,0.5]:40
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
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:22.2222467Z] gc.heap.generation: gen2
Value: 2
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:22.2222467Z] gc.heap.generation: gen1
Value: 1
(2025-10-06T16:06:22.2320093Z, 2025-10-06T16:09:22.2222467Z] gc.heap.generation: gen0
Value: 4

Metric Name: dotnet.process.memory.working_set, Description: The number of bytes of physical memory mapped to the process context., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320147Z, 2025-10-06T16:09:22.2222468Z]
Value: 235257856

Metric Name: dotnet.gc.heap.total_allocated, Description: The approximate number of bytes allocated on the managed GC heap since the process has started. The returned value does not include any native allocations., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320198Z, 2025-10-06T16:09:22.2222469Z]
Value: 108986552

Metric Name: dotnet.gc.last_collection.memory.committed_size, Description: The amount of committed virtual memory in use by the .NET GC, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320260Z, 2025-10-06T16:09:22.2222471Z]
Value: 55922688

Metric Name: dotnet.gc.last_collection.heap.size, Description: The managed GC heap size (including fragmentation), as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:22.2222472Z] gc.heap.generation: gen0
Value: 1774392
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:22.2222472Z] gc.heap.generation: gen1
Value: 7071360
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:22.2222472Z] gc.heap.generation: gen2
Value: 3900296
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:22.2222472Z] gc.heap.generation: loh
Value: 6731584
(2025-10-06T16:06:22.2320309Z, 2025-10-06T16:09:22.2222472Z] gc.heap.generation: poh
Value: 412000

Metric Name: dotnet.gc.last_collection.heap.fragmentation.size, Description: The heap fragmentation, as observed during the latest garbage collection., Unit: By, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:22.2222474Z] gc.heap.generation: gen0
Value: 1550288
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:22.2222474Z] gc.heap.generation: gen1
Value: 102832
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:22.2222474Z] gc.heap.generation: gen2
Value: 4616
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:22.2222474Z] gc.heap.generation: loh
Value: 1504
(2025-10-06T16:06:22.2320354Z, 2025-10-06T16:09:22.2222474Z] gc.heap.generation: poh
Value: 0

Metric Name: dotnet.gc.pause.time, Description: The total amount of time paused in GC since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380009Z, 2025-10-06T16:09:22.2222476Z]
Value: 0.044872

Metric Name: dotnet.jit.compiled_il.size, Description: Count of bytes of intermediate language that have been compiled since the process has started., Unit: By, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2380373Z, 2025-10-06T16:09:22.2222478Z]
Value: 2887943

Metric Name: dotnet.jit.compiled_methods, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: {method}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388753Z, 2025-10-06T16:09:22.2222479Z]
Value: 36408

Metric Name: dotnet.jit.compilation.time, Description: The number of times the JIT compiler (re)compiled methods since the process has started., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388853Z, 2025-10-06T16:09:22.2222481Z]
Value: 10.2074812

Metric Name: dotnet.monitor.lock_contentions, Description: The number of times there was contention when trying to acquire a monitor lock since the process has started., Unit: {contention}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2388918Z, 2025-10-06T16:09:22.2222482Z]
Value: 18

Metric Name: dotnet.thread_pool.thread.count, Description: The number of thread pool threads that currently exist., Unit: {thread}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389013Z, 2025-10-06T16:09:22.2222484Z]
Value: 4

Metric Name: dotnet.thread_pool.work_item.count, Description: The number of work items that the thread pool has completed since the process has started., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389083Z, 2025-10-06T16:09:22.2222485Z]
Value: 6011

Metric Name: dotnet.thread_pool.queue.length, Description: The number of work items that are currently queued to be processed by the thread pool., Unit: {work_item}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389144Z, 2025-10-06T16:09:22.2222487Z]
Value: 0

Metric Name: dotnet.timer.count, Description: The number of timer instances that are currently active. An active timer is registered to tick at some point in the future and has not yet been canceled., Unit: {timer}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389195Z, 2025-10-06T16:09:22.2222488Z]
Value: 2

Metric Name: dotnet.assembly.count, Description: The number of .NET assemblies that are currently loaded., Unit: {assembly}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389248Z, 2025-10-06T16:09:22.2222489Z]
Value: 171

Metric Name: dotnet.exceptions, Description: The number of exceptions that have been thrown in managed code., Unit: {exception}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:09:22.2222491Z] error.type: NotSupportedException
Value: 666
(2025-10-06T16:06:22.2389299Z, 2025-10-06T16:09:22.2222491Z] error.type: IOException
Value: 1

Metric Name: dotnet.process.cpu.count, Description: The number of processors available to the process., Unit: {cpu}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389347Z, 2025-10-06T16:09:22.2222493Z]
Value: 12

Metric Name: dotnet.process.cpu.time, Description: CPU time used by the process., Unit: s, Metric Type: DoubleSum
Instrumentation scope (Meter):
        Name: System.Runtime
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:09:22.2222495Z] cpu.mode: user
Value: 10.421875
(2025-10-06T16:06:22.2389415Z, 2025-10-06T16:09:22.2222495Z] cpu.mode: system
Value: 3.0625

Metric Name: aspnetcore.routing.match_attempts, Description: Number of requests that were attempted to be matched to an endpoint., Unit: {match_attempt}, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: Microsoft.AspNetCore.Routing
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:22.2222501Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Contacts
Value: 51
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:22.2222501Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Tags
Value: 30
(2025-10-06T16:06:22.2879778Z, 2025-10-06T16:09:22.2222501Z] aspnetcore.routing.is_fallback: false aspnetcore.routing.match_status: success http.route: api/Groups
Value: 30

Metric Name: http.client.active_requests, Description: Number of outbound HTTP requests that are currently active on the client., Unit: {request}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7014081Z, 2025-10-06T16:09:22.2222506Z] http.request.method: GET server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.request.duration, Description: Duration of HTTP client requests., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7016785Z, 2025-10-06T16:09:22.2222511Z] http.request.method: GET http.response.status_code: 200 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0237139 Count: 1 Min: 0.0237139 Max: 0.0237139
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: http.client.open_connections, Description: Number of outbound HTTP connections that are currently active or idle on the client., Unit: {connection}, Metric Type: LongSumNonMonotonic
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:09:22.2222515Z] http.connection.state: idle network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0
(2025-10-06T16:06:58.7017167Z, 2025-10-06T16:09:22.2222515Z] http.connection.state: active network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: 0

Metric Name: http.client.connection.duration, Description: The duration of successfully established outbound HTTP connections., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017565Z, 2025-10-06T16:09:22.2222522Z] network.peer.address: ::1 network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 75.015 Count: 1 Min: 75.015 Max: 75.015
(-Infinity,0.01]:0
(0.01,0.02]:0
(0.02,0.05]:0
(0.05,0.1]:0
(0.1,0.2]:0
(0.2,0.5]:0
(0.5,1]:0
(1,2]:0
(2,5]:0
(5,10]:0
(10,30]:0
(30,60]:0
(60,120]:1
(120,300]:0
(300,+Infinity]:0


Metric Name: http.client.request.time_in_queue, Description: The amount of time requests spent on a queue waiting for an available connection., Unit: s, Metric Type: Histogram
Instrumentation scope (Meter):
        Name: System.Net.Http
(2025-10-06T16:06:58.7017737Z, 2025-10-06T16:09:22.2222527Z] http.request.method: GET network.protocol.version: 1.1 server.address: localhost server.port: 50755 url.scheme: http
Value: Sum: 0.0120319 Count: 1 Min: 0.0120319 Max: 0.0120319
(-Infinity,0.005]:0
(0.005,0.01]:0
(0.01,0.025]:1
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


Metric Name: contacts.created, Description: Number of contacts created, Unit: contacts, Metric Type: LongSum
Instrumentation scope (Meter):
        Name: MyOpenTelemetryApi.Contacts
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-11 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-15 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-19 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-23 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-26 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-30 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-33 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-37 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-40 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Wayne Enterprises-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Stark Industries-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Themyscira Inc-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Bugle-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
(2025-10-06T16:06:58.8800348Z, 2025-10-06T16:09:22.2222533Z] company: Daily Planet-2025-10-06-12-08-44 has.email: true has.phone: true
Value: 1
