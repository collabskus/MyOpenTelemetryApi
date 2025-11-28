# Export ASP.NET Project Files to Single Text File
# PowerShell 5 compatible script

param(
    [string]$ProjectPath = ".",
    [string]$OutputFile = "project_export.txt"
)

# Define file extensions to include
$IncludeExtensions = @(
    "*.cs",           # C# files
    "*.json",         # JSON configuration files
    "*.xml",          # XML files
    "*.csproj",       # C# project files
    "*.sln",          # Solution files
    "*.config",       # Configuration files
    "*.cshtml",       # Razor views
    "*.razor",        # Razor components
    "*.js",           # JavaScript files
    "*.css",          # CSS files
    "*.scss",         # SCSS files
    "*.html",         # HTML files
    "*.yml",          # YAML files
    "*.yaml",         # YAML files
    "*.sql",          # SQL files
    "*.props",        # MSBuild props files
    "*.targets",      # MSBuild targets files
    "*.sh"            # Shell scripts
)

# Specific files without extensions to include
$IncludeSpecificFiles = @(
    "Dockerfile",
    "Dockerfile.*",
    ".dockerignore",
    ".editorconfig",
    ".gitignore",
    ".gitattributes"
)

# Directories to exclude
$ExcludeDirectories = @(
    "bin",
    "obj",
    ".vs",
    ".git",
    "node_modules",
    "packages",
    ".vscode",
    ".idea",
    "docs"            # Documentation folder
)

# Files to exclude
$ExcludeFiles = @(
    "*.exe",
    "*.dll",
    "*.pdb",
    "*.cache",
    "*.log",
    "*.md",           # Markdown files
    "*.txt",          # Text files (except specific ones)
    "LICENSE*",       # License files
    "LICENCE*"        # Alternative spelling
)

Write-Host "Starting project export..." -ForegroundColor Green
Write-Host "Project Path: $ProjectPath" -ForegroundColor Yellow
Write-Host "Output File: $OutputFile" -ForegroundColor Yellow

# Initialize output file
$OutputPath = Join-Path $ProjectPath $OutputFile
"" | Out-File -FilePath $OutputPath -Encoding UTF8

# Add header
$Header = @"
===============================================================================
ASP.NET PROJECT EXPORT
Generated: $(Get-Date)
Project Path: $((Resolve-Path $ProjectPath).Path)
===============================================================================

"@

$Header | Out-File -FilePath $OutputPath -Append -Encoding UTF8

# Generate directory structure using tree command if available, otherwise use PowerShell
Write-Host "Generating directory structure..." -ForegroundColor Cyan

"DIRECTORY STRUCTURE:" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
"===================" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
"" | Out-File -FilePath $OutputPath -Append -Encoding UTF8

# Try to use tree command first
try {
    $treeOutput = & tree $ProjectPath /F /A 2>$null
    if ($LASTEXITCODE -eq 0) {
        $treeOutput | Out-File -FilePath $OutputPath -Append -Encoding UTF8
    } else {
        throw "Tree command failed"
    }
} catch {
    # Fallback to PowerShell-based tree
    Write-Host "Tree command not available, using PowerShell alternative..." -ForegroundColor Yellow

    function Get-DirectoryTree {
        param([string]$Path, [string]$Prefix = "")

        $items = Get-ChildItem -Path $Path -Force | Where-Object {
            $_.Name -notin $ExcludeDirectories
        } | Sort-Object @{Expression={$_.PSIsContainer}; Descending=$true}, Name

        for ($i = 0; $i -lt $items.Count; $i++) {
            $item = $items[$i]
            $isLast = ($i -eq $items.Count - 1)
            $connector = if ($isLast) { "+-- " } else { "+-- " }

            "$Prefix$connector$($item.Name)" | Out-File -FilePath $OutputPath -Append -Encoding UTF8

            if ($item.PSIsContainer) {
                $newPrefix = if ($isLast) { "$Prefix    " } else { "$Prefix|   " }
                Get-DirectoryTree -Path $item.FullName -Prefix $newPrefix
            }
        }
    }

    (Split-Path $ProjectPath -Leaf) | Out-File -FilePath $OutputPath -Append -Encoding UTF8
    Get-DirectoryTree -Path $ProjectPath
}

"" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
"" | Out-File -FilePath $OutputPath -Append -Encoding UTF8

# Get all relevant files
Write-Host "Collecting files..." -ForegroundColor Cyan

$AllFiles = @()

# Collect files by extension
foreach ($extension in $IncludeExtensions) {
    $files = Get-ChildItem -Path $ProjectPath -Recurse -Include $extension -File | Where-Object {
        $exclude = $false
        
        # Check excluded directories
        foreach ($excludeDir in $ExcludeDirectories) {
            if ($_.FullName -like "*\$excludeDir\*") {
                $exclude = $true
                break
            }
        }
        
        # Check excluded files
        if (-not $exclude) {
            foreach ($excludeFile in $ExcludeFiles) {
                if ($_.Name -like $excludeFile) {
                    $exclude = $true
                    break
                }
            }
        }
        
        -not $exclude
    }
    $AllFiles += $files
}

# Collect specific files without extensions (like Dockerfile)
foreach ($specificFile in $IncludeSpecificFiles) {
    $files = Get-ChildItem -Path $ProjectPath -Recurse -Include $specificFile -File | Where-Object {
        $exclude = $false
        
        # Check excluded directories
        foreach ($excludeDir in $ExcludeDirectories) {
            if ($_.FullName -like "*\$excludeDir\*") {
                $exclude = $true
                break
            }
        }
        
        -not $exclude
    }
    $AllFiles += $files
}

# Remove duplicates and sort
$AllFiles = $AllFiles | Sort-Object FullName -Unique

Write-Host "Found $($AllFiles.Count) files to export" -ForegroundColor Green

# Export each file
"FILE CONTENTS:" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
"==============" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
"" | Out-File -FilePath $OutputPath -Append -Encoding UTF8

$fileCount = 0
foreach ($file in $AllFiles) {
    $fileCount++
    $relativePath = $file.FullName.Substring($ProjectPath.Length).TrimStart('\')

    Write-Host "Processing ($fileCount/$($AllFiles.Count)): $relativePath" -ForegroundColor White

    $separator = "=" * 80
    $fileHeader = @"
$separator
FILE: $relativePath
SIZE: $([math]::Round($file.Length / 1KB, 2)) KB
MODIFIED: $($file.LastWriteTime)
$separator

"@

    $fileHeader | Out-File -FilePath $OutputPath -Append -Encoding UTF8

    try {
        # Read file content with error handling
        $content = Get-Content -Path $file.FullName -Raw -ErrorAction Stop
        if ($content) {
            $content | Out-File -FilePath $OutputPath -Append -Encoding UTF8
        } else {
            "[EMPTY FILE]" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
        }
    } catch {
        "[ERROR READING FILE: $($_.Exception.Message)]" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
    }

    "" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
    "" | Out-File -FilePath $OutputPath -Append -Encoding UTF8
}

# Add footer
$Footer = @"
===============================================================================
EXPORT COMPLETED: $(Get-Date)
Total Files Exported: $fileCount
Output File: $OutputPath
===============================================================================
"@

$Footer | Out-File -FilePath $OutputPath -Append -Encoding UTF8

Write-Host "`nExport completed successfully!" -ForegroundColor Green
Write-Host "Output file: $OutputPath" -ForegroundColor Yellow
Write-Host "Total files exported: $fileCount" -ForegroundColor Green

# Display file size
$outputFileInfo = Get-Item $OutputPath
Write-Host "Output file size: $([math]::Round($outputFileInfo.Length / 1MB, 2)) MB" -ForegroundColor Cyan
