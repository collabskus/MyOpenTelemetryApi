Windows PowerShell
Copyright (C) Microsoft Corporation. All rights reserved.

Install the latest PowerShell for new features and improvements! https://aka.ms/PSWindows

PS C:\Users\kushal> Get-Date -Format "yyyy-MM-dd HH:mm:ss";
2025-12-17 10:15:32
PS C:\Users\kushal> Set-Location "C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\"; dotnet --info; dotnet clean; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet build; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet test; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet clean; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git add .; Get-Date -Format "yyyy-MM-dd-HH-mm-ss";  git commit --message "add existing files"; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git remote show origin; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git fetch; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git pull; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git status; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git clean -dfx; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; .\Export-Project.ps1 -ProjectPath "C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\" -OutputFile "my_project_export.txt"; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git status; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git add .; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git commit --message "add all files" --message "update project"; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git push origin --all; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet outdated; Get-Date -Format "yyyy-MM-dd-HH-mm-ss";
.NET SDK:
 Version:           10.0.101
 Commit:            fad253f51b
 Workload version:  10.0.100-manifests.9f71effe
 MSBuild version:   18.0.6+fad253f51

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.26100
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\10.0.101\

.NET workloads installed:
There are no installed workloads to display.
Configured to use workload sets when installing new manifests.
No workload sets are installed. Run "dotnet workload restore" to install a workload set.

Host:
  Version:      10.0.1
  Architecture: x64
  Commit:       fad253f51b

.NET SDKs installed:
  9.0.308 [C:\Program Files\dotnet\sdk]
  10.0.100-rc.1.25451.107 [C:\Program Files\dotnet\sdk]
  10.0.101 [C:\Program Files\dotnet\sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 10.0.1 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 10.0.1 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
  Microsoft.WindowsDesktop.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
  Microsoft.WindowsDesktop.App 10.0.1 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]

Other architectures found:
  x86   [C:\Program Files (x86)\dotnet]
    registered at [HKLM\SOFTWARE\dotnet\Setup\InstalledVersions\x86\InstallLocation]

Environment variables:
  Not set

global.json file:
  Not found

Learn more:
  https://aka.ms/dotnet/info

Download .NET:
  https://aka.ms/dotnet/download

Build succeeded in 0.9s
2025-12-17-10-15-42
Restore complete (0.9s)
  MyOpenTelemetryApi.Domain net10.0 succeeded (0.4s) → src\MyOpenTelemetryApi.Domain\bin\Debug\net10.0\MyOpenTelemetryApi.Domain.dll
  MyOpenTelemetryApi.Application net10.0 succeeded (0.6s) → src\MyOpenTelemetryApi.Application\bin\Debug\net10.0\MyOpenTelemetryApi.Application.dll
  MyOpenTelemetryApi.Infrastructure net10.0 succeeded (1.2s) → src\MyOpenTelemetryApi.Infrastructure\bin\Debug\net10.0\MyOpenTelemetryApi.Infrastructure.dll
  MyOpenTelemetryApi.Api net10.0 succeeded (1.7s) → src\MyOpenTelemetryApi.Api\bin\Debug\net10.0\MyOpenTelemetryApi.Api.dll
  MyOpenTelemetryApi.Infrastructure.Tests net10.0 succeeded (1.6s) → tests\MyOpenTelemetryApi.Infrastructure.Tests\bin\Debug\net10.0\MyOpenTelemetryApi.Infrastructure.Tests.dll
  MyOpenTelemetryApi.Api.Tests net10.0 succeeded (1.6s) → tests\MyOpenTelemetryApi.Api.Tests\bin\Debug\net10.0\MyOpenTelemetryApi.Api.Tests.dll
  MyOpenTelemetryApi.Application.Tests net10.0 succeeded (1.6s) → tests\MyOpenTelemetryApi.Application.Tests\bin\Debug\net10.0\MyOpenTelemetryApi.Application.Tests.dll

Build succeeded in 5.9s
2025-12-17-10-15-48
Restore complete (0.6s)
  MyOpenTelemetryApi.Domain net10.0 succeeded (0.1s) → src\MyOpenTelemetryApi.Domain\bin\Debug\net10.0\MyOpenTelemetryApi.Domain.dll
  MyOpenTelemetryApi.Application net10.0 succeeded (0.1s) → src\MyOpenTelemetryApi.Application\bin\Debug\net10.0\MyOpenTelemetryApi.Application.dll
  MyOpenTelemetryApi.Infrastructure net10.0 succeeded (0.1s) → src\MyOpenTelemetryApi.Infrastructure\bin\Debug\net10.0\MyOpenTelemetryApi.Infrastructure.dll
  MyOpenTelemetryApi.Api net10.0 succeeded (0.4s) → src\MyOpenTelemetryApi.Api\bin\Debug\net10.0\MyOpenTelemetryApi.Api.dll
  MyOpenTelemetryApi.Api.Tests net10.0 succeeded (0.2s) → tests\MyOpenTelemetryApi.Api.Tests\bin\Debug\net10.0\MyOpenTelemetryApi.Api.Tests.dll
  MyOpenTelemetryApi.Application.Tests net10.0 succeeded (0.2s) → tests\MyOpenTelemetryApi.Application.Tests\bin\Debug\net10.0\MyOpenTelemetryApi.Application.Tests.dll
  MyOpenTelemetryApi.Infrastructure.Tests net10.0 succeeded (0.2s) → tests\MyOpenTelemetryApi.Infrastructure.Tests\bin\Debug\net10.0\MyOpenTelemetryApi.Infrastructure.Tests.dll
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.1)
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.1)
[xUnit.net 00:00:00.00] xUnit.net VSTest Adapter v3.1.5+1b188a7b0a (64-bit .NET 10.0.1)
[xUnit.net 00:00:00.31]   Discovering: MyOpenTelemetryApi.Infrastructure.Tests
[xUnit.net 00:00:00.30]   Discovering: MyOpenTelemetryApi.Api.Tests
[xUnit.net 00:00:00.30]   Discovering: MyOpenTelemetryApi.Application.Tests
[xUnit.net 00:00:00.35]   Discovered:  MyOpenTelemetryApi.Api.Tests
[xUnit.net 00:00:00.36]   Discovered:  MyOpenTelemetryApi.Infrastructure.Tests
[xUnit.net 00:00:00.38]   Starting:    MyOpenTelemetryApi.Api.Tests
[xUnit.net 00:00:00.38]   Starting:    MyOpenTelemetryApi.Infrastructure.Tests
[xUnit.net 00:00:00.37]   Discovered:  MyOpenTelemetryApi.Application.Tests
[xUnit.net 00:00:00.40]   Starting:    MyOpenTelemetryApi.Application.Tests
[xUnit.net 00:00:00.58]   Finished:    MyOpenTelemetryApi.Infrastructure.Tests
[xUnit.net 00:00:00.58]   Finished:    MyOpenTelemetryApi.Api.Tests
  MyOpenTelemetryApi.Infrastructure.Tests test net10.0 succeeded (1.7s)
  MyOpenTelemetryApi.Api.Tests test net10.0 succeeded (1.7s)
[xUnit.net 00:00:00.60]   Finished:    MyOpenTelemetryApi.Application.Tests
  MyOpenTelemetryApi.Application.Tests test net10.0 succeeded (1.8s)

Test summary: total: 44, failed: 0, succeeded: 44, skipped: 0, duration: 1.8s
Build succeeded in 3.5s
2025-12-17-10-15-52

Build succeeded in 0.6s
2025-12-17-10-15-53
warning: in the working copy of 'my_project_export.txt', LF will be replaced by CRLF the next time Git touches it
2025-12-17-10-15-53
[main 436cc8b] add existing files
 1 file changed, 58 insertions(+), 1949 deletions(-)
2025-12-17-10-15-53
* remote origin
  Fetch URL: https://github.com/collabskus/MyOpenTelemetryApi.git
  Push  URL: https://github.com/collabskus/MyOpenTelemetryApi.git
  HEAD branch: main
  Remote branches:
    ci/2025-10-20-09-55                                                                              tracked
    ci/2025-10-20-10-02                                                                              tracked
    ci/2025-10-20-10-06                                                                              tracked
    ci/2025-10-20-10-07                                                                              tracked
    ci/2025-10-20-10-16                                                                              tracked
    ci/2025-10-20-10-36                                                                              tracked
    ci/2025-10-20-10-55                                                                              tracked
    ci/2025-10-20-11-01                                                                              tracked
    dependabot/github_actions/actions/checkout-6                                                     tracked
    dependabot/github_actions/actions/upload-artifact-6                                              new (next fetch will store in remotes/origin)
    dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.5.1                        tracked
    dependabot/nuget/microsoft-packages-20c2670d85                                                   new (next fetch will store in remotes/origin)
    main                                                                                             tracked
    refs/remotes/origin/dependabot/github_actions/actions/checkout-5                                 stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/actions/setup-dotnet-5                             stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/actions/upload-artifact-5                          stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.12   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.13   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.14   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.16   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.17   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.18   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.5.0    stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/github/codeql-action-4                             stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/nuget/tests/MyOpenTelemetryApi.Api.Tests/test-packages-d1750de658 stale (use 'git remote prune' to remove)
    refs/remotes/origin/feat/dotnet-10                                                               stale (use 'git remote prune' to remove)
  Local branch configured for 'git pull':
    main merges with remote main
  Local ref configured for 'git push':
    main pushes to main (local out of date)
2025-12-17-10-15-54
remote: Enumerating objects: 104, done.
remote: Counting objects: 100% (104/104), done.
remote: Compressing objects: 100% (68/68), done.
remote: Total 98 (delta 64), reused 60 (delta 30), pack-reused 0 (from 0)
Unpacking objects: 100% (98/98), 11.44 KiB | 9.00 KiB/s, done.
From https://github.com/collabskus/MyOpenTelemetryApi
   1a8cb71..596f4d8  main       -> origin/main
 * [new branch]      dependabot/github_actions/actions/upload-artifact-6 -> origin/dependabot/github_actions/actions/upload-artifact-6
 * [new branch]      dependabot/nuget/microsoft-packages-20c2670d85 -> origin/dependabot/nuget/microsoft-packages-20c2670d85
2025-12-17-10-15-55
Successfully rebased and updated refs/heads/main.
2025-12-17-10-15-56
On branch main
Your branch is ahead of 'origin/main' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean
2025-12-17-10-15-56
Removing src/MyOpenTelemetryApi.Api/bin/
Removing src/MyOpenTelemetryApi.Api/obj/
Removing src/MyOpenTelemetryApi.Application/bin/
Removing src/MyOpenTelemetryApi.Application/obj/
Removing src/MyOpenTelemetryApi.Domain/bin/
Removing src/MyOpenTelemetryApi.Domain/obj/
Removing src/MyOpenTelemetryApi.Infrastructure/bin/
Removing src/MyOpenTelemetryApi.Infrastructure/obj/
Removing tests/MyOpenTelemetryApi.Api.Tests/bin/
Removing tests/MyOpenTelemetryApi.Api.Tests/obj/
Removing tests/MyOpenTelemetryApi.Application.Tests/bin/
Removing tests/MyOpenTelemetryApi.Application.Tests/obj/
Removing tests/MyOpenTelemetryApi.Infrastructure.Tests/bin/
Removing tests/MyOpenTelemetryApi.Infrastructure.Tests/obj/
2025-12-17-10-15-56
Starting project export...
Project Path: C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\
Output File: my_project_export.txt
Generating directory structure...
Collecting files...
Found 91 files to export
Processing (1/91): .dockerignore
Processing (2/91): .editorconfig
Processing (3/91): .gitattributes
Processing (4/91): .github\dependabot.yml
Processing (5/91): .github\workflows\ci.yml
Processing (6/91): .github\workflows\codeql.yml
Processing (7/91): .gitignore
Processing (8/91): appsettings.Container.json
Processing (9/91): Directory.Build.props
Processing (10/91): Directory.Build.targets
Processing (11/91): Directory.Packages.props
Processing (12/91): docker-compose.yml
Processing (13/91): Dockerfile
Processing (14/91): Dockerfile.migrations
Processing (15/91): MyOpenTelemetryApi.sln
Processing (16/91): podman-compose.yml
Processing (17/91): src\MyOpenTelemetryApi.Api\appsettings.Development.json
Processing (18/91): src\MyOpenTelemetryApi.Api\appsettings.json
Processing (19/91): src\MyOpenTelemetryApi.Api\appsettings.Production.json
Processing (20/91): src\MyOpenTelemetryApi.Api\Authentication\ApiKeyAuthenticationHandler.cs
Processing (21/91): src\MyOpenTelemetryApi.Api\Controllers\ContactsController.cs
Processing (22/91): src\MyOpenTelemetryApi.Api\Controllers\GroupsController.cs
Processing (23/91): src\MyOpenTelemetryApi.Api\Controllers\HealthController.cs
Processing (24/91): src\MyOpenTelemetryApi.Api\Controllers\TagsController.cs
Processing (25/91): src\MyOpenTelemetryApi.Api\dependencies.json
Processing (26/91): src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj
Processing (27/91): src\MyOpenTelemetryApi.Api\Program.cs
Processing (28/91): src\MyOpenTelemetryApi.Api\Properties\launchSettings.json
Processing (29/91): src\MyOpenTelemetryApi.Api\Telemetry\FileExporter.cs
Processing (30/91): src\MyOpenTelemetryApi.Api\Telemetry\TelemetryConstants.cs
Processing (31/91): src\MyOpenTelemetryApi.Api\Telemetry\TelemetryExtensions.cs
Processing (32/91): src\MyOpenTelemetryApi.Application\DTOs\AddressDto.cs
Processing (33/91): src\MyOpenTelemetryApi.Application\DTOs\ContactDto.cs
Processing (34/91): src\MyOpenTelemetryApi.Application\DTOs\ContactSummaryDto.cs
Processing (35/91): src\MyOpenTelemetryApi.Application\DTOs\CreateContactDto.cs
Processing (36/91): src\MyOpenTelemetryApi.Application\DTOs\EmailAddressDto.cs
Processing (37/91): src\MyOpenTelemetryApi.Application\DTOs\GroupDto.cs
Processing (38/91): src\MyOpenTelemetryApi.Application\DTOs\PaginatedResultDto.cs
Processing (39/91): src\MyOpenTelemetryApi.Application\DTOs\PhoneNumberDto.cs
Processing (40/91): src\MyOpenTelemetryApi.Application\DTOs\TagDto.cs
Processing (41/91): src\MyOpenTelemetryApi.Application\DTOs\UpdateContactDto.cs
Processing (42/91): src\MyOpenTelemetryApi.Application\MyOpenTelemetryApi.Application.csproj
Processing (43/91): src\MyOpenTelemetryApi.Application\Services\ContactService.cs
Processing (44/91): src\MyOpenTelemetryApi.Application\Services\GroupService.cs
Processing (45/91): src\MyOpenTelemetryApi.Application\Services\IContactService.cs
Processing (46/91): src\MyOpenTelemetryApi.Application\Services\IGroupService.cs
Processing (47/91): src\MyOpenTelemetryApi.Application\Services\ITagService.cs
Processing (48/91): src\MyOpenTelemetryApi.Application\Services\TagService.cs
Processing (49/91): src\MyOpenTelemetryApi.Domain\Entities\Address.cs
Processing (50/91): src\MyOpenTelemetryApi.Domain\Entities\AddressType.cs
Processing (51/91): src\MyOpenTelemetryApi.Domain\Entities\Contact.cs
Processing (52/91): src\MyOpenTelemetryApi.Domain\Entities\ContactGroup.cs
Processing (53/91): src\MyOpenTelemetryApi.Domain\Entities\ContactTag.cs
Processing (54/91): src\MyOpenTelemetryApi.Domain\Entities\EmailAddress.cs
Processing (55/91): src\MyOpenTelemetryApi.Domain\Entities\EmailType.cs
Processing (56/91): src\MyOpenTelemetryApi.Domain\Entities\Group.cs
Processing (57/91): src\MyOpenTelemetryApi.Domain\Entities\PhoneNumber.cs
Processing (58/91): src\MyOpenTelemetryApi.Domain\Entities\PhoneType.cs
Processing (59/91): src\MyOpenTelemetryApi.Domain\Entities\Tag.cs
Processing (60/91): src\MyOpenTelemetryApi.Domain\Interfaces\IContactRepository.cs
Processing (61/91): src\MyOpenTelemetryApi.Domain\Interfaces\IGroupRepository.cs
Processing (62/91): src\MyOpenTelemetryApi.Domain\Interfaces\IRepository.cs
Processing (63/91): src\MyOpenTelemetryApi.Domain\Interfaces\ITagRepository.cs
Processing (64/91): src\MyOpenTelemetryApi.Domain\Interfaces\IUnitOfWork.cs
Processing (65/91): src\MyOpenTelemetryApi.Domain\MyOpenTelemetryApi.Domain.csproj
Processing (66/91): src\MyOpenTelemetryApi.Infrastructure\Data\AppDbContext.cs
Processing (67/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\AddressConfiguration.cs
Processing (68/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\ContactConfiguration.cs
Processing (69/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\ContactGroupConfiguration.cs
Processing (70/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\ContactTagConfiguration.cs
Processing (71/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\EmailAddressConfiguration.cs
Processing (72/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\GroupConfiguration.cs
Processing (73/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\PhoneNumberConfiguration.cs
Processing (74/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\TagConfiguration.cs
Processing (75/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20250804231722_InitialCreate.cs
Processing (76/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20250804231722_InitialCreate.Designer.cs
Processing (77/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20251003222820_AddContactPaginationIndexes.cs
Processing (78/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20251003222820_AddContactPaginationIndexes.Designer.cs
Processing (79/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\AppDbContextModelSnapshot.cs
Processing (80/91): src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj
Processing (81/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\ContactRepository.cs
Processing (82/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\GroupRepository.cs
Processing (83/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\Repository.cs
Processing (84/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\TagRepository.cs
Processing (85/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\UnitOfWork.cs
Processing (86/91): tests\MyOpenTelemetryApi.Api.Tests\MyOpenTelemetryApi.Api.Tests.csproj
Processing (87/91): tests\MyOpenTelemetryApi.Api.Tests\UnitTest1.cs
Processing (88/91): tests\MyOpenTelemetryApi.Application.Tests\MyOpenTelemetryApi.Application.Tests.csproj
Processing (89/91): tests\MyOpenTelemetryApi.Application.Tests\UnitTest1.cs
Processing (90/91): tests\MyOpenTelemetryApi.Infrastructure.Tests\MyOpenTelemetryApi.Infrastructure.Tests.csproj
Processing (91/91): tests\MyOpenTelemetryApi.Infrastructure.Tests\UnitTest1.cs

Export completed successfully!
Output file: C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\my_project_export.txt
Total files exported: 91
Output file size: 0.24 MB
2025-12-17-10-15-57
On branch main
Your branch is ahead of 'origin/main' by 1 commit.
  (use "git push" to publish your local commits)

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   my_project_export.txt

no changes added to commit (use "git add" and/or "git commit -a")
2025-12-17-10-15-57
warning: in the working copy of 'my_project_export.txt', LF will be replaced by CRLF the next time Git touches it
2025-12-17-10-15-57
[main 4fea184] add all files
 1 file changed, 106 insertions(+), 106 deletions(-)
2025-12-17-10-15-57
Enumerating objects: 11, done.
Counting objects: 100% (11/11), done.
Delta compression using up to 12 threads
Compressing objects: 100% (7/7), done.
Writing objects: 100% (7/7), 2.42 KiB | 827.00 KiB/s, done.
Total 7 (delta 5), reused 0 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (5/5), completed with 4 local objects.
To https://github.com/collabskus/MyOpenTelemetryApi.git
   596f4d8..4fea184  main -> main
2025-12-17-10-15-58
Discovering projects...
Analyzing project(s)...
Analyzing dependencies...
» MyOpenTelemetryApi.Api
  [net10.0]
  Microsoft.AspNetCore.OpenApi          10.0.0 -> 10.0.1
  Microsoft.EntityFrameworkCore.Design  10.0.0 -> 10.0.1

» MyOpenTelemetryApi.Application
  [net10.0]
  Microsoft.Extensions.Logging.Abstractions  10.0.0 -> 10.0.1

» MyOpenTelemetryApi.Infrastructure
  [net10.0]
  Microsoft.EntityFrameworkCore         10.0.0 -> 10.0.1
  Microsoft.EntityFrameworkCore.Design  10.0.0 -> 10.0.1

Version color legend:
<red>   : Major version update or pre-release version. Possible breaking changes.
<yellow>: Minor version update. Backwards-compatible features added.
<green> : Patch version update. Backwards-compatible bug fixes.

You can upgrade packages to the latest version by passing the -u or -u:prompt option.
Elapsed: 00:00:02.9752289
2025-12-17-10-16-02
PS C:\Users\kushal\Source\Repos\MyOpenTelemetryApi> Set-Location "C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\"; dotnet --info; dotnet clean; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet build; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet test; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet clean; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git add .; Get-Date -Format "yyyy-MM-dd-HH-mm-ss";  git commit --message "add existing files"; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git remote show origin; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git fetch; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git pull; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git status; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git clean -dfx; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; .\Export-Project.ps1 -ProjectPath "C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\" -OutputFile "my_project_export.txt"; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git status; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git add .; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git commit --message "add all files" --message "update project"; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; git push origin --all; Get-Date -Format "yyyy-MM-dd-HH-mm-ss"; dotnet outdated; Get-Date -Format "yyyy-MM-dd-HH-mm-ss";
.NET SDK:
 Version:           10.0.101
 Commit:            fad253f51b
 Workload version:  10.0.100-manifests.9f71effe
 MSBuild version:   18.0.6+fad253f51

Runtime Environment:
 OS Name:     Windows
 OS Version:  10.0.26100
 OS Platform: Windows
 RID:         win-x64
 Base Path:   C:\Program Files\dotnet\sdk\10.0.101\

.NET workloads installed:
There are no installed workloads to display.
Configured to use workload sets when installing new manifests.
No workload sets are installed. Run "dotnet workload restore" to install a workload set.

Host:
  Version:      10.0.1
  Architecture: x64
  Commit:       fad253f51b

.NET SDKs installed:
  9.0.308 [C:\Program Files\dotnet\sdk]
  10.0.100-rc.1.25451.107 [C:\Program Files\dotnet\sdk]
  10.0.101 [C:\Program Files\dotnet\sdk]

.NET runtimes installed:
  Microsoft.AspNetCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.AspNetCore.App 10.0.1 [C:\Program Files\dotnet\shared\Microsoft.AspNetCore.App]
  Microsoft.NETCore.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.NETCore.App 10.0.1 [C:\Program Files\dotnet\shared\Microsoft.NETCore.App]
  Microsoft.WindowsDesktop.App 8.0.22 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
  Microsoft.WindowsDesktop.App 9.0.11 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]
  Microsoft.WindowsDesktop.App 10.0.1 [C:\Program Files\dotnet\shared\Microsoft.WindowsDesktop.App]

Other architectures found:
  x86   [C:\Program Files (x86)\dotnet]
    registered at [HKLM\SOFTWARE\dotnet\Setup\InstalledVersions\x86\InstallLocation]

Environment variables:
  Not set

global.json file:
  Not found

Learn more:
  https://aka.ms/dotnet/info

Download .NET:
  https://aka.ms/dotnet/download

Build succeeded in 0.7s
2025-12-17-10-25-36
    C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj : error NU1109:
      Detected package downgrade: Microsoft.EntityFrameworkCore.Relational from 10.0.1 to centrally defined 10.0.0. Update the centrally managed package version to a higher version.
       MyOpenTelemetryApi.Infrastructure -> Microsoft.EntityFrameworkCore.Design 10.0.1 -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.1)
       MyOpenTelemetryApi.Infrastructure -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.0)
    C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj : error NU1109:
      Detected package downgrade: Microsoft.EntityFrameworkCore.Relational from 10.0.1 to centrally defined 10.0.0. Update the centrally managed package version to a higher version.
       MyOpenTelemetryApi.Api -> Microsoft.EntityFrameworkCore.Design 10.0.1 -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.1)
       MyOpenTelemetryApi.Api -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.0)

Restore failed with 2 error(s) in 0.9s
2025-12-17-10-25-37
    C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj : error NU1109:
      Detected package downgrade: Microsoft.EntityFrameworkCore.Relational from 10.0.1 to centrally defined 10.0.0. Update the centrally managed package version to a higher version.
       MyOpenTelemetryApi.Infrastructure -> Microsoft.EntityFrameworkCore.Design 10.0.1 -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.1)
       MyOpenTelemetryApi.Infrastructure -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.0)
    C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj : error NU1109:
      Detected package downgrade: Microsoft.EntityFrameworkCore.Relational from 10.0.1 to centrally defined 10.0.0. Update the centrally managed package version to a higher version.
       MyOpenTelemetryApi.Api -> Microsoft.EntityFrameworkCore.Design 10.0.1 -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.1)
       MyOpenTelemetryApi.Api -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.0)

Restore failed with 2 error(s) in 0.9s
2025-12-17-10-25-38

Build succeeded in 1.8s
2025-12-17-10-25-41
2025-12-17-10-25-41
On branch main
Your branch is ahead of 'origin/main' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean
2025-12-17-10-25-41
* remote origin
  Fetch URL: https://github.com/collabskus/MyOpenTelemetryApi.git
  Push  URL: https://github.com/collabskus/MyOpenTelemetryApi.git
  HEAD branch: main
  Remote branches:
    ci/2025-10-20-09-55                                                                              tracked
    ci/2025-10-20-10-02                                                                              tracked
    ci/2025-10-20-10-06                                                                              tracked
    ci/2025-10-20-10-07                                                                              tracked
    ci/2025-10-20-10-16                                                                              tracked
    ci/2025-10-20-10-36                                                                              tracked
    ci/2025-10-20-10-55                                                                              tracked
    ci/2025-10-20-11-01                                                                              tracked
    dependabot/github_actions/actions/checkout-6                                                     tracked
    dependabot/github_actions/actions/upload-artifact-6                                              tracked
    dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.5.1                        tracked
    dependabot/nuget/microsoft-packages-20c2670d85                                                   tracked
    main                                                                                             tracked
    refs/remotes/origin/dependabot/github_actions/actions/checkout-5                                 stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/actions/setup-dotnet-5                             stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/actions/upload-artifact-5                          stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.12   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.13   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.14   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.16   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.17   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.4.18   stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/danielpalme/ReportGenerator-GitHub-Action-5.5.0    stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/github_actions/github/codeql-action-4                             stale (use 'git remote prune' to remove)
    refs/remotes/origin/dependabot/nuget/tests/MyOpenTelemetryApi.Api.Tests/test-packages-d1750de658 stale (use 'git remote prune' to remove)
    refs/remotes/origin/feat/dotnet-10                                                               stale (use 'git remote prune' to remove)
  Local branch configured for 'git pull':
    main merges with remote main
  Local ref configured for 'git push':
    main pushes to main (fast-forwardable)
2025-12-17-10-25-41
2025-12-17-10-25-41
Current branch main is up to date.
2025-12-17-10-25-42
On branch main
Your branch is ahead of 'origin/main' by 1 commit.
  (use "git push" to publish your local commits)

nothing to commit, working tree clean
2025-12-17-10-25-42
Removing .vs/
Removing src/MyOpenTelemetryApi.Api/MyOpenTelemetryApi.Api.csproj.user
Removing src/MyOpenTelemetryApi.Api/bin/
Removing src/MyOpenTelemetryApi.Api/obj/
Removing src/MyOpenTelemetryApi.Application/bin/
Removing src/MyOpenTelemetryApi.Application/obj/
Removing src/MyOpenTelemetryApi.Domain/bin/
Removing src/MyOpenTelemetryApi.Domain/obj/
Removing src/MyOpenTelemetryApi.Infrastructure/bin/
Removing src/MyOpenTelemetryApi.Infrastructure/obj/
Removing tests/MyOpenTelemetryApi.Api.Tests/bin/
Removing tests/MyOpenTelemetryApi.Api.Tests/obj/
Removing tests/MyOpenTelemetryApi.Application.Tests/bin/
Removing tests/MyOpenTelemetryApi.Application.Tests/obj/
Removing tests/MyOpenTelemetryApi.Infrastructure.Tests/bin/
Removing tests/MyOpenTelemetryApi.Infrastructure.Tests/obj/
2025-12-17-10-25-42
Starting project export...
Project Path: C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\
Output File: my_project_export.txt
Generating directory structure...
Collecting files...
Found 91 files to export
Processing (1/91): .dockerignore
Processing (2/91): .editorconfig
Processing (3/91): .gitattributes
Processing (4/91): .github\dependabot.yml
Processing (5/91): .github\workflows\ci.yml
Processing (6/91): .github\workflows\codeql.yml
Processing (7/91): .gitignore
Processing (8/91): appsettings.Container.json
Processing (9/91): Directory.Build.props
Processing (10/91): Directory.Build.targets
Processing (11/91): Directory.Packages.props
Processing (12/91): docker-compose.yml
Processing (13/91): Dockerfile
Processing (14/91): Dockerfile.migrations
Processing (15/91): MyOpenTelemetryApi.sln
Processing (16/91): podman-compose.yml
Processing (17/91): src\MyOpenTelemetryApi.Api\appsettings.Development.json
Processing (18/91): src\MyOpenTelemetryApi.Api\appsettings.json
Processing (19/91): src\MyOpenTelemetryApi.Api\appsettings.Production.json
Processing (20/91): src\MyOpenTelemetryApi.Api\Authentication\ApiKeyAuthenticationHandler.cs
Processing (21/91): src\MyOpenTelemetryApi.Api\Controllers\ContactsController.cs
Processing (22/91): src\MyOpenTelemetryApi.Api\Controllers\GroupsController.cs
Processing (23/91): src\MyOpenTelemetryApi.Api\Controllers\HealthController.cs
Processing (24/91): src\MyOpenTelemetryApi.Api\Controllers\TagsController.cs
Processing (25/91): src\MyOpenTelemetryApi.Api\dependencies.json
Processing (26/91): src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj
Processing (27/91): src\MyOpenTelemetryApi.Api\Program.cs
Processing (28/91): src\MyOpenTelemetryApi.Api\Properties\launchSettings.json
Processing (29/91): src\MyOpenTelemetryApi.Api\Telemetry\FileExporter.cs
Processing (30/91): src\MyOpenTelemetryApi.Api\Telemetry\TelemetryConstants.cs
Processing (31/91): src\MyOpenTelemetryApi.Api\Telemetry\TelemetryExtensions.cs
Processing (32/91): src\MyOpenTelemetryApi.Application\DTOs\AddressDto.cs
Processing (33/91): src\MyOpenTelemetryApi.Application\DTOs\ContactDto.cs
Processing (34/91): src\MyOpenTelemetryApi.Application\DTOs\ContactSummaryDto.cs
Processing (35/91): src\MyOpenTelemetryApi.Application\DTOs\CreateContactDto.cs
Processing (36/91): src\MyOpenTelemetryApi.Application\DTOs\EmailAddressDto.cs
Processing (37/91): src\MyOpenTelemetryApi.Application\DTOs\GroupDto.cs
Processing (38/91): src\MyOpenTelemetryApi.Application\DTOs\PaginatedResultDto.cs
Processing (39/91): src\MyOpenTelemetryApi.Application\DTOs\PhoneNumberDto.cs
Processing (40/91): src\MyOpenTelemetryApi.Application\DTOs\TagDto.cs
Processing (41/91): src\MyOpenTelemetryApi.Application\DTOs\UpdateContactDto.cs
Processing (42/91): src\MyOpenTelemetryApi.Application\MyOpenTelemetryApi.Application.csproj
Processing (43/91): src\MyOpenTelemetryApi.Application\Services\ContactService.cs
Processing (44/91): src\MyOpenTelemetryApi.Application\Services\GroupService.cs
Processing (45/91): src\MyOpenTelemetryApi.Application\Services\IContactService.cs
Processing (46/91): src\MyOpenTelemetryApi.Application\Services\IGroupService.cs
Processing (47/91): src\MyOpenTelemetryApi.Application\Services\ITagService.cs
Processing (48/91): src\MyOpenTelemetryApi.Application\Services\TagService.cs
Processing (49/91): src\MyOpenTelemetryApi.Domain\Entities\Address.cs
Processing (50/91): src\MyOpenTelemetryApi.Domain\Entities\AddressType.cs
Processing (51/91): src\MyOpenTelemetryApi.Domain\Entities\Contact.cs
Processing (52/91): src\MyOpenTelemetryApi.Domain\Entities\ContactGroup.cs
Processing (53/91): src\MyOpenTelemetryApi.Domain\Entities\ContactTag.cs
Processing (54/91): src\MyOpenTelemetryApi.Domain\Entities\EmailAddress.cs
Processing (55/91): src\MyOpenTelemetryApi.Domain\Entities\EmailType.cs
Processing (56/91): src\MyOpenTelemetryApi.Domain\Entities\Group.cs
Processing (57/91): src\MyOpenTelemetryApi.Domain\Entities\PhoneNumber.cs
Processing (58/91): src\MyOpenTelemetryApi.Domain\Entities\PhoneType.cs
Processing (59/91): src\MyOpenTelemetryApi.Domain\Entities\Tag.cs
Processing (60/91): src\MyOpenTelemetryApi.Domain\Interfaces\IContactRepository.cs
Processing (61/91): src\MyOpenTelemetryApi.Domain\Interfaces\IGroupRepository.cs
Processing (62/91): src\MyOpenTelemetryApi.Domain\Interfaces\IRepository.cs
Processing (63/91): src\MyOpenTelemetryApi.Domain\Interfaces\ITagRepository.cs
Processing (64/91): src\MyOpenTelemetryApi.Domain\Interfaces\IUnitOfWork.cs
Processing (65/91): src\MyOpenTelemetryApi.Domain\MyOpenTelemetryApi.Domain.csproj
Processing (66/91): src\MyOpenTelemetryApi.Infrastructure\Data\AppDbContext.cs
Processing (67/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\AddressConfiguration.cs
Processing (68/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\ContactConfiguration.cs
Processing (69/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\ContactGroupConfiguration.cs
Processing (70/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\ContactTagConfiguration.cs
Processing (71/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\EmailAddressConfiguration.cs
Processing (72/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\GroupConfiguration.cs
Processing (73/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\PhoneNumberConfiguration.cs
Processing (74/91): src\MyOpenTelemetryApi.Infrastructure\Data\Configurations\TagConfiguration.cs
Processing (75/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20250804231722_InitialCreate.cs
Processing (76/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20250804231722_InitialCreate.Designer.cs
Processing (77/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20251003222820_AddContactPaginationIndexes.cs
Processing (78/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\20251003222820_AddContactPaginationIndexes.Designer.cs
Processing (79/91): src\MyOpenTelemetryApi.Infrastructure\Data\Migrations\AppDbContextModelSnapshot.cs
Processing (80/91): src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj
Processing (81/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\ContactRepository.cs
Processing (82/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\GroupRepository.cs
Processing (83/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\Repository.cs
Processing (84/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\TagRepository.cs
Processing (85/91): src\MyOpenTelemetryApi.Infrastructure\Repositories\UnitOfWork.cs
Processing (86/91): tests\MyOpenTelemetryApi.Api.Tests\MyOpenTelemetryApi.Api.Tests.csproj
Processing (87/91): tests\MyOpenTelemetryApi.Api.Tests\UnitTest1.cs
Processing (88/91): tests\MyOpenTelemetryApi.Application.Tests\MyOpenTelemetryApi.Application.Tests.csproj
Processing (89/91): tests\MyOpenTelemetryApi.Application.Tests\UnitTest1.cs
Processing (90/91): tests\MyOpenTelemetryApi.Infrastructure.Tests\MyOpenTelemetryApi.Infrastructure.Tests.csproj
Processing (91/91): tests\MyOpenTelemetryApi.Infrastructure.Tests\UnitTest1.cs

Export completed successfully!
Output file: C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\my_project_export.txt
Total files exported: 91
Output file size: 0.24 MB
2025-12-17-10-25-43
On branch main
Your branch is ahead of 'origin/main' by 1 commit.
  (use "git push" to publish your local commits)

Changes not staged for commit:
  (use "git add <file>..." to update what will be committed)
  (use "git restore <file>..." to discard changes in working directory)
        modified:   my_project_export.txt

no changes added to commit (use "git add" and/or "git commit -a")
2025-12-17-10-25-43
warning: in the working copy of 'my_project_export.txt', LF will be replaced by CRLF the next time Git touches it
2025-12-17-10-25-43
[main 32b15da] add all files
 1 file changed, 9 insertions(+), 10 deletions(-)
2025-12-17-10-25-43
Enumerating objects: 21, done.
Counting objects: 100% (21/21), done.
Delta compression using up to 12 threads
Compressing objects: 100% (12/12), done.
Writing objects: 100% (12/12), 8.59 KiB | 4.29 MiB/s, done.
Total 12 (delta 9), reused 0 (delta 0), pack-reused 0 (from 0)
remote: Resolving deltas: 100% (9/9), completed with 8 local objects.
To https://github.com/collabskus/MyOpenTelemetryApi.git
   4fea184..32b15da  main -> main
2025-12-17-10-25-44
Discovering projects...
Analyzing project(s)...
Unable to process the project `C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln. Are you sure this is a valid .NET Core or .NET Standard project type?

Here is the full error message returned from the Microsoft Build Engine:

MSBuild version 18.0.6+fad253f51 for .NET
  Determining projects to restore...
  Restored C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Domain\MyOpenTelemetryApi.Domain.csproj (in 81 ms).
  Restored C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Application\MyOpenTelemetryApi.Application.csproj (in 170 ms).
  Restored C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\tests\MyOpenTelemetryApi.Api.Tests\MyOpenTelemetryApi.Api.Tests.csproj (in 226 ms).
  Restored C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\tests\MyOpenTelemetryApi.Application.Tests\MyOpenTelemetryApi.Application.Tests.csproj (in 226 ms).
  Restored C:\Users\kushal\source\repos\MyOpenTelemetryApi\tests\MyOpenTelemetryApi.Infrastructure.Tests\MyOpenTelemetryApi.Infrastructure.Tests.csproj (in 226 ms).
C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj : error NU1109: Detected package downgrade: Microsoft.EntityFrameworkCore.Relational from 10.0.1 to centrally defined 10.0.0. Update the centrally managed package version to a higher version.  [C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln]
C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj : error NU1109:  MyOpenTelemetryApi.Api -> Microsoft.EntityFrameworkCore.Design 10.0.1 -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.1)  [C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln]
C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj : error NU1109:  MyOpenTelemetryApi.Api -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.0) [C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln]
C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj : error NU1109: Detected package downgrade: Microsoft.EntityFrameworkCore.Relational from 10.0.1 to centrally defined 10.0.0. Update the centrally managed package version to a higher version.  [C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln]
C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj : error NU1109:  MyOpenTelemetryApi.Infrastructure -> Microsoft.EntityFrameworkCore.Design 10.0.1 -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.1)  [C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln]
C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj : error NU1109:  MyOpenTelemetryApi.Infrastructure -> Microsoft.EntityFrameworkCore.Relational (>= 10.0.0) [C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\MyOpenTelemetryApi.sln]
  Failed to restore C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Api\MyOpenTelemetryApi.Api.csproj (in 245 ms).
  Failed to restore C:\Users\kushal\source\repos\MyOpenTelemetryApi\src\MyOpenTelemetryApi.Infrastructure\MyOpenTelemetryApi.Infrastructure.csproj (in 245 ms).
 -  - exit code: 1
2025-12-17-10-25-46
PS C:\Users\kushal\Source\Repos\MyOpenTelemetryApi>
