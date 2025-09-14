#!/bin/bash

# cleanup-and-retry.sh - Clean up containers and retry setup

set -e

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${BLUE}🧹 Cleaning up containers and trying again...${NC}"

# Stop and remove any existing containers
echo -e "${YELLOW}Stopping containers...${NC}"
podman stop myotel-api myotel-postgres myotel-migrations 2>/dev/null || true

echo -e "${YELLOW}Removing containers...${NC}"
podman rm myotel-api myotel-postgres myotel-migrations 2>/dev/null || true

# Force remove any containers that might be stuck
echo -e "${YELLOW}Force removing any stuck containers...${NC}"
podman rm -f myotel-api myotel-postgres myotel-migrations 2>/dev/null || true

# Remove containers by ID if they still exist
echo -e "${YELLOW}Checking for remaining containers by name...${NC}"
POSTGRES_ID=$(podman ps -aq --filter "name=myotel-postgres" 2>/dev/null || true)
API_ID=$(podman ps -aq --filter "name=myotel-api" 2>/dev/null || true)
MIGRATION_ID=$(podman ps -aq --filter "name=myotel-migrations" 2>/dev/null || true)

if [ ! -z "$POSTGRES_ID" ]; then
    echo -e "${YELLOW}Removing PostgreSQL container by ID: $POSTGRES_ID${NC}"
    podman rm -f "$POSTGRES_ID" 2>/dev/null || true
fi

if [ ! -z "$API_ID" ]; then
    echo -e "${YELLOW}Removing API container by ID: $API_ID${NC}"
    podman rm -f "$API_ID" 2>/dev/null || true
fi

if [ ! -z "$MIGRATION_ID" ]; then
    echo -e "${YELLOW}Removing migration container by ID: $MIGRATION_ID${NC}"
    podman rm -f "$MIGRATION_ID" 2>/dev/null || true
fi

# Remove the built image so it gets rebuilt with fixes
echo -e "${YELLOW}Removing built images...${NC}"
podman rmi localhost/myopentelemetryapi_api 2>/dev/null || true
podman rmi myopentelemetryapi_api 2>/dev/null || true

# Clean up networks
echo -e "${YELLOW}Cleaning up networks...${NC}"
podman network rm myopentelemetryapi_myotel-network 2>/dev/null || true

# Optional: Clean up volumes (uncomment if you want to reset data)
echo -e "${YELLOW}Cleaning up volumes...${NC}"
podman volume rm myopentelemetryapi_postgres_data 2>/dev/null || true

# Pull the PostgreSQL image with fully qualified name
echo -e "${BLUE}📦 Pre-pulling PostgreSQL image...${NC}"
podman pull docker.io/library/postgres:16-alpine

echo -e "${GREEN}✅ Cleanup completed${NC}"
echo -e "${BLUE}🚀 Now running setup...${NC}"

# Run the setup script
bash setup-podman.sh "$@"
