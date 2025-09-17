# .NET Project Build and Git Workflow Script
# This script builds, tests, and syncs a .NET project with Git

# Function to log timestamped messages
function Write-TimestampedLog {
    param([string]$Message)
    $timestamp = Get-Date -Format "yyyy-MM-dd HH:mm:ss"
    Write-Host "[$timestamp] $Message" -ForegroundColor Green
}

# Set project directory
$ProjectPath = "C:\Users\kushal\Source\Repos\MyOpenTelemetryApi\"
Set-Location $ProjectPath

try {
    # Phase 0: format dotnet 
    dotnet format

    Write-TimestampedLog "Staging existing files..."
    git add .
    
    Write-TimestampedLog "Committing existing files..."
    git commit --message "add existing files"

    # Phase 1: Clean and build project
    Write-TimestampedLog "Starting project clean..."
    dotnet clean
    
    Write-TimestampedLog "Building project..."
    dotnet build
    
    Write-TimestampedLog "Running tests..."
    dotnet test
    
    Write-TimestampedLog "Final cleanup..."
    dotnet clean
    
    # Phase 2: Initial Git operations
    Write-TimestampedLog "Staging existing files..."
    git add .
    
    Write-TimestampedLog "Committing existing files..."
    git commit --message "add existing files"
    
    Write-TimestampedLog "Checking remote repository..."
    git remote show origin
    
    # Phase 3: Sync with remote
    Write-TimestampedLog "Fetching from remote..."
    git fetch
    
    Write-TimestampedLog "Pulling latest changes..."
    git pull
    
    Write-TimestampedLog "Checking repository status..."
    git status
    
    # Phase 4: Deep clean and export
    Write-TimestampedLog "Performing deep clean (removes untracked files)..."
    git clean -dfx
    
    Write-TimestampedLog "Running project export..."
    .\Export-Project.ps1 -ProjectPath $ProjectPath -OutputFile "my_project_export.txt"
    
    # Phase 5: Final commit and push
    Write-TimestampedLog "Checking status after export..."
    git status
    
    Write-TimestampedLog "Staging all changes..."
    git add .
    
    Write-TimestampedLog "Committing final changes..."
    git commit --message "add all files" --message "update project"
    
    Write-TimestampedLog "Pushing to remote repository..."
    git push origin --all
    
    Write-TimestampedLog "Workflow completed successfully!"
    
} catch {
    Write-Host "Error occurred: $($_.Exception.Message)" -ForegroundColor Red
    Write-TimestampedLog "Workflow failed at: $($_.ScriptStackTrace)"
}
