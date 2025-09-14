kushal@texas:~/src/MyOpenTelemetryApi$ time bash emergency-cleanup.sh
🚨 EMERGENCY CLEANUP - This will force remove everything
========================================================
Are you sure you want to force cleanup everything? (yes/no): yes
🛑 Stopping ALL containers with myotel prefix...
0f2d1130c01d
4ab02d285b39
🗑️ Force removing ALL containers with myotel prefix...
4ab02d285b39
Error: container 0f2d1130c01de35e4d1e9faf3fcd4e101c51aaf3dbdb7ec3457ba1498866e3cd has dependent containers which must be removed before it: 4ab02d285b39ac40b1aad85fc237096dbcf0ec7c7faf06f9b7aa0f0c63636813: container already exists

real    0m4.103s
user    0m0.284s
sys     0m0.131s
kushal@texas:~/src/MyOpenTelemetryApi$





The issue is that there are container dependencies - one container depends on another, so we need to remove them in the right order. Let me fix the emergency cleanup script to handle dependencies properly:Now let me also add a simpler approach - using `podman-compose down` to properly handle dependencies:Let me also create a simpler, more targeted cleanup script:Perfect! Now you have better cleanup options. Try this:

## 🚀 **Recommended approach:**

```bash
# Make the quick cleanup script executable  
chmod +x quick-cleanup.sh

# Use compose to handle dependencies properly
./quick-cleanup.sh

# Then start fresh
./setup-podman.sh
```

## 🔄 **If that doesn't work, try the updated emergency cleanup:**

```bash
# The emergency cleanup now handles dependencies better
./emergency-cleanup.sh
```

## 🧠 **Why this happened:**

The error shows that container `0f2d1130c01d` (postgres) has a dependent container `4ab02d285b39` (api). Podman won't let you remove the postgres container while the API container depends on it.

## 🎯 **The quick-cleanup.sh approach:**

1. **Uses compose down** - This properly handles dependencies
2. **Tries all compose files** - Covers all possible setups  
3. **Includes --remove-orphans** - Cleans up dangling containers
4. **Includes --volumes** - Resets data volumes too
5. **Removes built images** - Forces rebuild

## 🛠️ **Manual approach if needed:**

```bash
# Remove dependent containers first
podman rm -f myotel-api myotel-migrations 2>/dev/null || true

# Then remove postgres
podman rm -f myotel-postgres 2>/dev/null || true

# Then start fresh
./setup-podman.sh
```

The `quick-cleanup.sh` script should handle this much more elegantly by using compose to understand and respect the container dependencies!
