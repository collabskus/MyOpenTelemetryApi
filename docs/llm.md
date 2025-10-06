Run docker build -t myopentelemetryapi:4bb1b051f8425991592fab1712cd770ed94c790d .
#0 building with "default" instance using docker driver

#1 [internal] load build definition from Dockerfile
#1 transferring dockerfile: 1.59kB done
#1 DONE 0.0s

#2 [internal] load metadata for mcr.microsoft.com/dotnet/sdk:10.0
#2 DONE 0.2s

#3 [internal] load metadata for mcr.microsoft.com/dotnet/aspnet:10.0
#3 DONE 0.2s

#4 [internal] load .dockerignore
#4 transferring context: 757B done
#4 DONE 0.0s

#5 [internal] load build context
#5 transferring context: 158.85kB 0.0s done
#5 DONE 0.0s

#6 [build 1/9] FROM mcr.microsoft.com/dotnet/sdk:10.0@sha256:eee11b0bf11715710bbe8339b9641f0ef8b5d8a8e07f2d6ff3cd4361c1a4e5a7
#6 resolve mcr.microsoft.com/dotnet/sdk:10.0@sha256:eee11b0bf11715710bbe8339b9641f0ef8b5d8a8e07f2d6ff3cd4361c1a4e5a7 done
#6 sha256:eee11b0bf11715710bbe8339b9641f0ef8b5d8a8e07f2d6ff3cd4361c1a4e5a7 1.08kB / 1.08kB done
#6 sha256:c803b0c46ee7743acff1cca33d076f443b3788a3e614040ebdfc90dd90cbcec4 6.11kB / 6.11kB done
#6 sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 0B / 36.73MB 0.1s
#6 sha256:ba6682e85914bb0c86a6332ea0c34ca0bae972f8c75e9ccb8814fb156bc6302a 2.42kB / 2.42kB done
#6 sha256:4b3ffd8ccb5201a0fc03585952effb4ed2d1ea5e704d2e7330212fb8b16c86a3 16.78MB / 29.72MB 0.1s
#6 sha256:2402f184b298c60e76a706603c07fcd68eaa1b9f1f63e6657267841b6b40b76b 6.29MB / 16.82MB 0.1s
#6 sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 8.39MB / 36.73MB 0.2s
#6 sha256:4b3ffd8ccb5201a0fc03585952effb4ed2d1ea5e704d2e7330212fb8b16c86a3 29.72MB / 29.72MB 0.2s done
#6 sha256:2402f184b298c60e76a706603c07fcd68eaa1b9f1f63e6657267841b6b40b76b 16.82MB / 16.82MB 0.2s done
#6 sha256:62ab85e35613bd530ae32cb2d20907c8da3bf366694c6d923f7067df782fa3a5 151B / 151B 0.2s done
#6 sha256:cea598e37e28daf964888c5313b148ab4e42105b3a8c18f9d299e37035971654 0B / 12.74MB 0.2s
#6 sha256:943163fb04d913bf4aa38b4a157c1d28ca5f4421c46a52be4c1171c8651b9b84 0B / 23.60MB 0.2s
#6 extracting sha256:4b3ffd8ccb5201a0fc03585952effb4ed2d1ea5e704d2e7330212fb8b16c86a3
#6 sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 34.60MB / 36.73MB 0.3s
#6 sha256:cea598e37e28daf964888c5313b148ab4e42105b3a8c18f9d299e37035971654 12.74MB / 12.74MB 0.3s done
#6 sha256:943163fb04d913bf4aa38b4a157c1d28ca5f4421c46a52be4c1171c8651b9b84 16.78MB / 23.60MB 0.3s
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 0B / 197.10MB 0.3s
#6 sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 36.73MB / 36.73MB 0.3s done
#6 sha256:943163fb04d913bf4aa38b4a157c1d28ca5f4421c46a52be4c1171c8651b9b84 23.60MB / 23.60MB 0.3s done
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 25.17MB / 197.10MB 0.4s
#6 sha256:689960b1aeb22febcb70cd5d301173d14763b92bb8655a9594971cef13913f32 487B / 487B 0.3s done
#6 sha256:a1a2110ed8d7c4c3237969d0e324fd9c3060124798f6773b79e56c6d0a7ecf02 6.29MB / 17.60MB 0.4s
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 48.23MB / 197.10MB 0.5s
#6 sha256:a1a2110ed8d7c4c3237969d0e324fd9c3060124798f6773b79e56c6d0a7ecf02 17.60MB / 17.60MB 0.4s done
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 72.35MB / 197.10MB 0.6s
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 99.61MB / 197.10MB 0.7s
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 150.99MB / 197.10MB 0.9s
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 178.26MB / 197.10MB 1.0s
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 197.10MB / 197.10MB 1.2s
#6 extracting sha256:4b3ffd8ccb5201a0fc03585952effb4ed2d1ea5e704d2e7330212fb8b16c86a3 1.0s done
#6 sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 197.10MB / 197.10MB 1.2s done
#6 extracting sha256:2402f184b298c60e76a706603c07fcd68eaa1b9f1f63e6657267841b6b40b76b 0.1s
#6 extracting sha256:2402f184b298c60e76a706603c07fcd68eaa1b9f1f63e6657267841b6b40b76b 0.5s done
#6 extracting sha256:3582fc513aa66c56e8f49c569fc09bb18dd52af5ac1986eb1fff1f043662a992 done
#6 extracting sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 0.1s
#6 extracting sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 0.4s done
#6 extracting sha256:62ab85e35613bd530ae32cb2d20907c8da3bf366694c6d923f7067df782fa3a5 done
#6 extracting sha256:cea598e37e28daf964888c5313b148ab4e42105b3a8c18f9d299e37035971654
#6 ...

#7 [runtime 1/4] FROM mcr.microsoft.com/dotnet/aspnet:10.0@sha256:d9a0d4006dbbc14d877b00c5e7113b432bac6bca6d12816a6e8fd999bac72797
#7 resolve mcr.microsoft.com/dotnet/aspnet:10.0@sha256:d9a0d4006dbbc14d877b00c5e7113b432bac6bca6d12816a6e8fd999bac72797 done
#7 sha256:d9a0d4006dbbc14d877b00c5e7113b432bac6bca6d12816a6e8fd999bac72797 1.08kB / 1.08kB done
#7 sha256:8ef1da55850a6d8abdeb041cc79ba975b8d1fb39b2edecc189eb56c67e3b5816 1.58kB / 1.58kB done
#7 sha256:9f5c454872f3cd4db3cd1a6b35b3ca0021865078fe7e25ef2df10bfc8a1932e4 3.36kB / 3.36kB done
#7 sha256:3582fc513aa66c56e8f49c569fc09bb18dd52af5ac1986eb1fff1f043662a992 3.53kB / 3.53kB 0.1s done
#7 sha256:2a78cc5ebff71b8f71af12824e3c990dec862bfd442272608895b553c69fee13 36.73MB / 36.73MB 0.3s done
#7 sha256:62ab85e35613bd530ae32cb2d20907c8da3bf366694c6d923f7067df782fa3a5 151B / 151B 0.2s done
#7 sha256:cea598e37e28daf964888c5313b148ab4e42105b3a8c18f9d299e37035971654 12.74MB / 12.74MB 0.3s done
#7 sha256:4b3ffd8ccb5201a0fc03585952effb4ed2d1ea5e704d2e7330212fb8b16c86a3 29.72MB / 29.72MB 0.2s done
#7 sha256:2402f184b298c60e76a706603c07fcd68eaa1b9f1f63e6657267841b6b40b76b 16.82MB / 16.82MB 0.2s done
#7 DONE 2.6s

#8 [runtime 2/4] WORKDIR /app
#8 DONE 0.0s

#6 [build 1/9] FROM mcr.microsoft.com/dotnet/sdk:10.0@sha256:eee11b0bf11715710bbe8339b9641f0ef8b5d8a8e07f2d6ff3cd4361c1a4e5a7
#6 extracting sha256:cea598e37e28daf964888c5313b148ab4e42105b3a8c18f9d299e37035971654 0.1s done
#6 extracting sha256:943163fb04d913bf4aa38b4a157c1d28ca5f4421c46a52be4c1171c8651b9b84 0.1s
#6 extracting sha256:943163fb04d913bf4aa38b4a157c1d28ca5f4421c46a52be4c1171c8651b9b84 0.8s done
#6 extracting sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32
#6 extracting sha256:4e66d9571ea0263690ebcad4fc8cac5e149b9432f8a181fdd412b6aa641f0a32 3.4s done
#6 extracting sha256:689960b1aeb22febcb70cd5d301173d14763b92bb8655a9594971cef13913f32
#6 extracting sha256:689960b1aeb22febcb70cd5d301173d14763b92bb8655a9594971cef13913f32 done
#6 extracting sha256:a1a2110ed8d7c4c3237969d0e324fd9c3060124798f6773b79e56c6d0a7ecf02 0.1s
#6 extracting sha256:a1a2110ed8d7c4c3237969d0e324fd9c3060124798f6773b79e56c6d0a7ecf02 0.3s done
#6 DONE 8.4s

#9 [build 2/9] WORKDIR /src
#9 DONE 0.0s

#10 [build 3/9] COPY [src/MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj, MyOpenTelemetryApi.Api/]
#10 DONE 0.0s

#11 [build 4/9] COPY [src/MyOpenTelemetryApi.Application/MyOpenTelemetryApi.Application.csproj, MyOpenTelemetryApi.Application/]
#11 DONE 0.0s

#12 [build 5/9] COPY [src/MyOpenTelemetryApi.Domain/MyOpenTelemetryApi.Domain.csproj, MyOpenTelemetryApi.Domain/]
#12 DONE 0.0s

#13 [build 6/9] COPY [src/MyOpenTelemetryApi.Infrastructure/MyOpenTelemetryApi.Infrastructure.csproj, MyOpenTelemetryApi.Infrastructure/]
#13 DONE 0.0s

#14 [build 7/9] RUN dotnet restore "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj"
#14 0.725   Determining projects to restore...
#14 1.268 /usr/share/dotnet/sdk/10.0.100-rc.1.25451.107/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.TargetFrameworkInference.targets(96,5): error NETSDK1013: The TargetFramework value '' was not recognized. It may be misspelled. If not, then the TargetFrameworkIdentifier and/or TargetFrameworkVersion properties must be specified explicitly. [/src/MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj]
#14 ERROR: process "/bin/sh -c dotnet restore \"MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj\"" did not complete successfully: exit code: 1
------
 > [build 7/9] RUN dotnet restore "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj":
0.725   Determining projects to restore...
1.268 /usr/share/dotnet/sdk/10.0.100-rc.1.25451.107/Sdks/Microsoft.NET.Sdk/targets/Microsoft.NET.TargetFrameworkInference.targets(96,5): error NETSDK1013: The TargetFramework value '' was not recognized. It may be misspelled. If not, then the TargetFrameworkIdentifier and/or TargetFrameworkVersion properties must be specified explicitly. [/src/MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj]
------
Dockerfile:11
--------------------
   9 |     COPY ["src/MyOpenTelemetryApi.Infrastructure/MyOpenTelemetryApi.Infrastructure.csproj", "MyOpenTelemetryApi.Infrastructure/"]
  10 |     
  11 | >>> RUN dotnet restore "MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj"
  12 |     
  13 |     # Copy source code
--------------------
ERROR: failed to build: failed to solve: process "/bin/sh -c dotnet restore \"MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj\"" did not complete successfully: exit code: 1
Error: Process completed with exit code 1.
