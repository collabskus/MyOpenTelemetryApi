#!/bin/bash

# quick-cleanup.sh - Simple cleanup using compose

set -e

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${BLUE}🧹 Quick cleanup using compose${NC}"
echo "================================"

# Determine compose command
if command -v podman-compose &> /dev/null; then
    COMPOSE_CMD="podman-compose"
elif command -v podman &> /dev/null && podman compose version &> /dev/null; then
    COMPOSE_CMD="podman compose"
else
    echo -e "${RED}❌ No compose command found${NC}"
    echo -e "${YELLOW}💡 Try running: ./emergency-cleanup.sh${NC}"
    exit 1
fi

echo -e "${BLUE}📦 Using compose command: ${COMPOSE_CMD}${NC}"

# Try all possible compose files
COMPOSE_FILES=("docker-compose.simple.yml" "docker-compose.yml" "podman-compose.yml")

for file in "${COMPOSE_FILES[@]}"; do
    if [ -f "$file" ]; then
        echo -e "${YELLOW}🔄 Cleaning up with $file...${NC}"
        $COMPOSE_CMD -f "$file" down --remove-orphans --volumes 2>/dev/null || true
    fi
done

# Also try without specifying a file (uses default docker-compose.yml)
echo -e "${YELLOW}🔄 Cleaning up default compose...${NC}"
$COMPOSE_CMD down --remove-orphans --volumes 2>/dev/null || true

# Clean up any remaining images
echo -e "${YELLOW}🖼️ Removing built images...${NC}"
podman rmi localhost/myopentelemetryapi_api 2>/dev/null || true
podman rmi myopentelemetryapi_api 2>/dev/null || true
podman rmi localhost/myopentelemetryapi_migrations 2>/dev/null || true
podman rmi myopentelemetryapi_migrations 2>/dev/null || true

echo -e "${GREEN}✅ Quick cleanup completed!${NC}"

# Check what's left
echo -e "\n${BLUE}📊 Remaining myotel containers:${NC}"
podman ps -a --filter "name=myotel" | grep myotel || echo "None found"
