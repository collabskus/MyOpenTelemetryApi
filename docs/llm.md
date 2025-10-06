Now let me create the updated docker-compose and podman-compose files:Now let me create a summary document:## Summary

I've created **4 updated files** for you:

1. **Dockerfile** - Main application container (CPM fixed)
2. **Dockerfile.migrations** - Database migrations container (CPM fixed)
3. **docker-compose.yml** - Docker Compose orchestration (no changes needed, but provided for reference)
4. **podman-compose.yml** - Podman Compose orchestration (no changes needed, but provided for reference)

### The Critical Change

Both Dockerfiles now have these two lines **BEFORE** copying .csproj files:
```dockerfile
COPY ["Directory.Build.props", "./"]
COPY ["Directory.Packages.props", "./"]
```

This ensures MSBuild can find:
- The `<TargetFramework>net10.0</TargetFramework>` property
- All centrally managed package versions

### To Apply

1. Copy the updated `Dockerfile` and `Dockerfile.migrations` to your project
2. Test locally: `docker build -t myopentelemetryapi .`
3. Commit and push to GitHub

Your GitHub Actions should now build successfully! 🎉
