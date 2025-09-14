#!/bin/bash

# emergency-cleanup.sh - Nuclear option for cleaning up stuck containers

set -e

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${RED}🚨 EMERGENCY CLEANUP - This will force remove everything${NC}"
echo "========================================================"

read -p "Are you sure you want to force cleanup everything? (yes/no): " confirm

if [ "$confirm" != "yes" ]; then
    echo -e "${YELLOW}Operation cancelled${NC}"
    exit 0
fi

echo -e "${YELLOW}🔄 Attempting compose down first (handles dependencies properly)...${NC}"
if command -v podman-compose &> /dev/null; then
    COMPOSE_CMD="podman-compose"
elif command -v podman &> /dev/null && podman compose version &> /dev/null; then
    COMPOSE_CMD="podman compose"
else
    COMPOSE_CMD=""
fi

if [ ! -z "$COMPOSE_CMD" ]; then
    echo -e "${BLUE}Using $COMPOSE_CMD to clean up...${NC}"
    $COMPOSE_CMD -f docker-compose.simple.yml down --remove-orphans 2>/dev/null || true
    $COMPOSE_CMD -f docker-compose.yml down --remove-orphans 2>/dev/null || true
    $COMPOSE_CMD -f podman-compose.yml down --remove-orphans 2>/dev/null || true
    echo -e "${GREEN}Compose cleanup completed${NC}"
else
    echo -e "${YELLOW}No compose command found, using manual cleanup${NC}"
fi

echo -e "${YELLOW}🛑 Stopping ALL containers with myotel prefix...${NC}"
podman ps -q --filter "name=myotel" | xargs -r podman stop

echo -e "${YELLOW}🗑️ Force removing dependent containers first...${NC}"
# Remove API container first (it depends on postgres)
podman ps -aq --filter "name=myotel-api" | xargs -r podman rm -f
podman ps -aq --filter "name=myotel-migrations" | xargs -r podman rm -f

echo -e "${YELLOW}🗑️ Force removing database container...${NC}"
# Then remove postgres container
podman ps -aq --filter "name=myotel-postgres" | xargs -r podman rm -f

echo -e "${YELLOW}🗑️ Force removing any remaining myotel containers...${NC}"
# Clean up any remaining ones
podman ps -aq --filter "name=myotel" | xargs -r podman rm -f

echo -e "${YELLOW}🧹 Removing containers by image (dependent containers first)...${NC}"
# Remove API containers first
podman ps -aq --filter "ancestor=localhost/myopentelemetryapi_api" | xargs -r podman rm -f
podman ps -aq --filter "ancestor=localhost/myopentelemetryapi_migrations" | xargs -r podman rm -f
# Then remove postgres containers
podman ps -aq --filter "ancestor=docker.io/library/postgres:16-alpine" | xargs -r podman rm -f

echo -e "${YELLOW}🖼️ Removing built images...${NC}"
podman rmi localhost/myopentelemetryapi_api 2>/dev/null || true
podman rmi myopentelemetryapi_api 2>/dev/null || true
podman rmi localhost/myopentelemetryapi_migrations 2>/dev/null || true
podman rmi myopentelemetryapi_migrations 2>/dev/null || true

echo -e "${YELLOW}🌐 Removing networks...${NC}"
podman network rm myopentelemetryapi_myotel-network 2>/dev/null || true
podman network rm myotel-network 2>/dev/null || true

echo -e "${YELLOW}💾 Removing volumes...${NC}"
podman volume rm myopentelemetryapi_postgres_data 2>/dev/null || true
podman volume rm myopentelemetryapi_portainer_data 2>/dev/null || true

echo -e "${YELLOW}🧹 Pruning unused containers and images...${NC}"
podman container prune -f
podman image prune -f

echo -e "${GREEN}✅ Emergency cleanup completed!${NC}"
echo -e "${BLUE}💡 You can now run './setup-podman.sh' to start fresh${NC}

# Show what's left
echo -e "\n${BLUE} Remaining containers:${NC}"
podman ps -a

echo -e "\n${BLUE} Remaining images:${NC}"
podman images | grep -E "(myotel|postgres)" || echo "None found"
