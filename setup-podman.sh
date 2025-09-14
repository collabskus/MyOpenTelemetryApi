#!/bin/bash

# setup-podman.sh - Script to set up and run MyOpenTelemetryApi with Podman

set -e  # Exit on any error

echo "🚀 Setting up MyOpenTelemetryApi with Podman"
echo "================================================"

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

# Check if podman is installed
if ! command -v podman &> /dev/null; then
    echo -e "${RED}❌ Podman is not installed. Please install Podman first.${NC}"
    exit 1
fi

# Check if podman-compose is available
if ! command -v podman-compose &> /dev/null; then
    echo -e "${YELLOW}⚠️  podman-compose not found. Using 'podman compose' instead.${NC}"
    COMPOSE_CMD="podman compose"
    COMPOSE_FILE="docker-compose.simple.yml"
else
    COMPOSE_CMD="podman-compose"
    COMPOSE_FILE="docker-compose.simple.yml"
fi

echo -e "${BLUE}📦 Using compose command: ${COMPOSE_CMD}${NC}"
echo -e "${BLUE}📄 Using compose file: ${COMPOSE_FILE}${NC}"

# Function to clean up existing containers and networks
cleanup() {
    echo -e "${YELLOW}🧹 Cleaning up existing containers and networks...${NC}"
    
    # Stop and remove containers
    podman stop myotel-api myotel-postgres 2>/dev/null || true
    podman rm myotel-api myotel-postgres 2>/dev/null || true
    
    # Remove volumes (optional - uncomment if you want to reset data)
    # podman volume rm myopentelemetryapi_postgres_data 2>/dev/null || true
    # podman volume rm myopentelemetryapi_portainer_data 2>/dev/null || true
    
    # Remove network
    podman network rm myopentelemetryapi_myotel-network 2>/dev/null || true
    
    echo -e "${GREEN}✅ Cleanup completed${NC}"
}

# Function to create necessary directories
setup_directories() {
    echo -e "${BLUE}📁 Creating necessary directories...${NC}"
    
    # Create logs directory
    mkdir -p ./logs
    chmod 755 ./logs
    
    # Create init-db directory for PostgreSQL initialization scripts
    mkdir -p ./init-db
    
    echo -e "${GREEN}✅ Directories created${NC}"
}

# Function to build and start services
start_services() {
    echo -e "${BLUE}🔨 Building and starting services...${NC}"
    
    # Build and start the services
    $COMPOSE_CMD up --build -d
    
    echo -e "${GREEN}✅ Services started${NC}"
}

# Function to wait for services to be healthy
wait_for_services() {
    echo -e "${BLUE}⏳ Waiting for services to be ready...${NC}"
    
    # Wait for PostgreSQL to be ready
    echo -e "${YELLOW}📊 Waiting for PostgreSQL...${NC}"
    for i in {1..30}; do
        if podman exec myotel-postgres pg_isready -U myoteluser -d myoteldb &>/dev/null; then
            echo -e "${GREEN}✅ PostgreSQL is ready${NC}"
            break
        fi
        echo -n "."
        sleep 3
        if [ $i -eq 30 ]; then
            echo -e "${RED}❌ PostgreSQL failed to start within 90 seconds${NC}"
            echo -e "${YELLOW}💡 Try running: podman logs myotel-postgres${NC}"
            exit 1
        fi
    done
    
    # Wait for API to be ready
    echo -e "${YELLOW}🌐 Waiting for API...${NC}"
    for i in {1..45}; do
        if curl -s http://localhost:5174/api/health &>/dev/null; then
            echo -e "${GREEN}✅ API is ready${NC}"
            break
        fi
        echo -n "."
        sleep 3
        if [ $i -eq 45 ]; then
            echo -e "${RED}❌ API failed to start within 135 seconds${NC}"
            echo -e "${YELLOW}💡 Try running: podman logs myotel-api${NC}"
            exit 1
        fi
    done
}

# Function to show service status
show_status() {
    echo -e "\n${GREEN}🎉 Services are running successfully!${NC}"
    echo -e "\n${BLUE}📋 Service Information:${NC}"
    echo "=================================="
    echo -e "🌐 API URL:        ${GREEN}http://localhost:5174${NC}"
    echo -e "🏥 Health Check:   ${GREEN}http://localhost:5174/api/health${NC}"
    echo -e "🏥 Ready Check:    ${GREEN}http://localhost:5174/api/health/ready${NC}"
    echo -e "🗄️  PostgreSQL:    ${GREEN}localhost:5432${NC}"
    echo -e "📊 Database:       ${GREEN}myoteldb${NC}"
    echo -e "👤 DB User:        ${GREEN}myoteluser${NC}"
    echo -e "🔑 DB Password:    ${GREEN}myotelpass123${NC}"
    echo -e "\n${BLUE}📂 Log Files:${NC}"
    echo -e "📝 Application Logs: ${GREEN}./logs/otel-logs.json${NC}"
    echo -e "\n${BLUE}🛠️  Useful Commands:${NC}"
    echo "=================================="
    echo -e "${YELLOW}View API logs:${NC}     $COMPOSE_CMD -f $COMPOSE_FILE logs -f api"
    echo -e "${YELLOW}View DB logs:${NC}      $COMPOSE_CMD -f $COMPOSE_FILE logs -f db"
    echo -e "${YELLOW}Stop services:${NC}     $COMPOSE_CMD -f $COMPOSE_FILE down"
    echo -e "${YELLOW}Restart API:${NC}       $COMPOSE_CMD -f $COMPOSE_FILE restart api"
    echo -e "${YELLOW}Shell into API:${NC}    podman exec -it myotel-api /bin/bash"
    echo -e "${YELLOW}Shell into DB:${NC}     podman exec -it myotel-postgres psql -U myoteluser -d myoteldb"
    echo -e "${YELLOW}View containers:${NC}   podman ps"
    echo -e "${YELLOW}Run migrations:${NC}    ./run-migrations.sh container"
    echo -e "${YELLOW}Test external access:${NC} ./test-external-access.sh"
}

# Function to test the API
test_api() {
    echo -e "\n${BLUE}🧪 Testing API endpoints...${NC}"
    
    echo -e "${YELLOW}Testing health endpoint...${NC}"
    if curl -s http://localhost:5174/api/health | jq . &>/dev/null; then
        echo -e "${GREEN}✅ Health endpoint working${NC}"
    else
        echo -e "${RED}❌ Health endpoint failed${NC}"
    fi
    
    echo -e "${YELLOW}Testing ready endpoint...${NC}"
    if curl -s http://localhost:5174/api/health/ready | jq . &>/dev/null; then
        echo -e "${GREEN}✅ Ready endpoint working${NC}"
    else
        echo -e "${RED}❌ Ready endpoint failed${NC}"
    fi
    
    echo -e "${YELLOW}Testing contacts endpoint...${NC}"
    if curl -s http://localhost:5174/api/contacts | jq . &>/dev/null; then
        echo -e "${GREEN}✅ Contacts endpoint working${NC}"
    else
        echo -e "${RED}❌ Contacts endpoint failed${NC}"
    fi
}

# Parse command line arguments
SKIP_CLEANUP=false
SKIP_TEST=false
SHOW_LOGS=false

while [[ $# -gt 0 ]]; do
    case $1 in
        --no-cleanup)
            SKIP_CLEANUP=true
            shift
            ;;
        --no-test)
            SKIP_TEST=true
            shift
            ;;
        --logs)
            SHOW_LOGS=true
            shift
            ;;
        --help|-h)
            echo "Usage: $0 [OPTIONS]"
            echo "Options:"
            echo "  --no-cleanup    Skip cleanup of existing containers"
            echo "  --no-test       Skip API testing"
            echo "  --logs          Show logs after startup"
            echo "  --help, -h      Show this help message"
            exit 0
            ;;
        *)
            echo -e "${RED}Unknown option: $1${NC}"
            exit 1
            ;;
    esac
done

# Main execution
main() {
    if [ "$SKIP_CLEANUP" != true ]; then
        cleanup
    fi
    
    setup_directories
    start_services
    wait_for_services
    show_status
    
    if [ "$SKIP_TEST" != true ]; then
        test_api
    fi
    
    if [ "$SHOW_LOGS" = true ]; then
        echo -e "\n${BLUE}📋 Showing API logs (Ctrl+C to exit):${NC}"
        $COMPOSE_CMD -f $COMPOSE_FILE logs -f api
    fi
}

# Run main function
main

echo -e "\n${GREEN}🎯 Setup completed successfully!${NC}"
echo -e "${BLUE}💡 Tip: Run '$COMPOSE_CMD -f $COMPOSE_FILE logs -f api' to follow application logs${NC}"
