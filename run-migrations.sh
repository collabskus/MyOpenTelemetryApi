#!/bin/bash

# run-migrations.sh - Script to run Entity Framework migrations

set -e

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${BLUE}🗄️ Entity Framework Migration Runner${NC}"
echo "========================================"

# Check if containers are running
if ! podman ps | grep -q myotel-postgres; then
    echo -e "${RED}❌ PostgreSQL container is not running${NC}"
    echo -e "${YELLOW}💡 Run './setup-podman.sh' first to start the containers${NC}"
    exit 1
fi

if ! podman ps | grep -q myotel-api; then
    echo -e "${RED}❌ API container is not running${NC}"
    echo -e "${YELLOW}💡 Run './setup-podman.sh' first to start the containers${NC}"
    exit 1
fi

# Function to run migrations using the API container (startup migrations)
check_automatic_migrations() {
    echo -e "${BLUE}🔄 Checking automatic migration status...${NC}"
    
    echo -e "${YELLOW}Automatic migrations run on container startup.${NC}"
    echo -e "${YELLOW}Checking API container logs for migration status...${NC}"
    
    if podman logs myotel-api 2>/dev/null | grep -q "Applying database migrations"; then
        if podman logs myotel-api 2>/dev/null | grep -q "Database migrations applied successfully"; then
            echo -e "${GREEN}✅ Automatic migrations completed successfully${NC}"
        else
            echo -e "${RED}❌ Automatic migrations may have failed${NC}"
            echo -e "${YELLOW}💡 Check logs: podman logs myotel-api${NC}"
        fi
    else
        echo -e "${YELLOW}⚠️  No migration logs found - container may still be starting${NC}"
    fi
    
    echo -e "${BLUE}💡 Migrations run automatically when the API container starts${NC}"
}

# Function to run migrations using dedicated migration container
run_migrations_with_container() {
    echo -e "${BLUE}🔄 Running migrations using dedicated migration container...${NC}"
    
    # Check if containers are running
    if ! podman ps | grep -q myotel-postgres; then
        echo -e "${RED}❌ PostgreSQL container is not running${NC}"
        echo -e "${YELLOW}💡 Run './setup-podman.sh' first to start the containers${NC}"
        exit 1
    fi
    
    # Determine which compose file to use
    if [ -f "docker-compose.simple.yml" ]; then
        COMPOSE_FILE="docker-compose.simple.yml"
    else
        COMPOSE_FILE="docker-compose.yml"
    fi
    
    # Determine compose command
    if command -v podman-compose &> /dev/null; then
        COMPOSE_CMD="podman-compose"
    else
        COMPOSE_CMD="podman compose"
    fi
    
    echo -e "${YELLOW}Building and running migration container...${NC}"
    $COMPOSE_CMD -f $COMPOSE_FILE --profile migrations run --rm migrations
    
    if [ $? -eq 0 ]; then
        echo -e "${GREEN}✅ Migrations completed successfully${NC}"
    else
        echo -e "${RED}❌ Migration failed${NC}"
        echo -e "${YELLOW}💡 Check logs above for details${NC}"
        exit 1
    fi
}
# Function to run migrations using local dotnet CLI
run_migrations_locally() {
    echo -e "${BLUE}🔄 Running migrations using local .NET CLI...${NC}"
    
    if ! command -v dotnet &> /dev/null; then
        echo -e "${RED}❌ .NET CLI not found locally${NC}"
        echo -e "${YELLOW}💡 Try using automatic migrations or manual schema creation${NC}"
        exit 1
    fi
    
    # Set the connection string for local execution - PostgreSQL is exposed on localhost:5432
    export ConnectionStrings__DefaultConnection="Host=localhost;Port=5432;Database=myoteldb;Username=myoteluser;Password=myotelpass123;"
    
    cd src/MyOpenTelemetryApi.Api
    
    echo -e "${YELLOW}📋 Listing pending migrations...${NC}"
    dotnet ef migrations list --verbose
    
    echo -e "${YELLOW}🔄 Applying migrations...${NC}"
    dotnet ef database update --verbose
    
    if [ $? -eq 0 ]; then
        echo -e "${GREEN}✅ Migrations completed successfully${NC}"
    else
        echo -e "${RED}❌ Migration failed${NC}"
        exit 1
    fi
    
    cd ../..
}

# Function to check database status
check_database_status() {
    echo -e "${BLUE}📊 Checking database status...${NC}"
    
    echo -e "${YELLOW}Testing database connection...${NC}"
    if podman exec myotel-postgres pg_isready -U myoteluser -d myoteldb; then
        echo -e "${GREEN}✅ Database connection OK${NC}"
    else
        echo -e "${RED}❌ Database connection failed${NC}"
        exit 1
    fi
    
    echo -e "${YELLOW}Listing existing tables...${NC}"
    podman exec -it myotel-postgres psql -U myoteluser -d myoteldb -c "\dt"
    
    echo -e "${YELLOW}Checking migration history...${NC}"
    podman exec -it myotel-postgres psql -U myoteluser -d myoteldb -c "SELECT * FROM \"__EFMigrationsHistory\";" 2>/dev/null || echo "No migration history table found"
}

# Function to reset database (destructive)
reset_database() {
    echo -e "${RED}⚠️  WARNING: This will DELETE ALL DATA in the database!${NC}"
    read -p "Are you sure you want to continue? (yes/no): " confirm
    
    if [ "$confirm" = "yes" ]; then
        echo -e "${YELLOW}🗑️ Dropping and recreating database...${NC}"
        
        # Drop and recreate database
        podman exec myotel-postgres psql -U myoteluser -d postgres -c "DROP DATABASE IF EXISTS myoteldb;"
        podman exec myotel-postgres psql -U myoteluser -d postgres -c "CREATE DATABASE myoteldb;"
        
        echo -e "${GREEN}✅ Database reset complete${NC}"
        echo -e "${BLUE}🔄 Now run migrations to recreate schema${NC}"
    else
        echo -e "${YELLOW}Operation cancelled${NC}"
    fi
}

# Function to create a new migration
create_migration() {
    local migration_name="$1"
    
    if [ -z "$migration_name" ]; then
        echo -e "${RED}❌ Migration name is required${NC}"
        echo -e "${YELLOW}Usage: $0 create <migration_name>${NC}"
        exit 1
    fi
    
    echo -e "${BLUE}📝 Creating new migration: $migration_name${NC}"
    
    if ! command -v dotnet &> /dev/null; then
        echo -e "${RED}❌ .NET CLI not found locally${NC}"
        echo -e "${YELLOW}💡 Install .NET SDK to create migrations${NC}"
        exit 1
    fi
    
    cd src/MyOpenTelemetryApi.Api
    
    # Set the connection string for local execution - PostgreSQL is exposed on localhost:5432
    export ConnectionStrings__DefaultConnection="Host=localhost;Port=5432;Database=myoteldb;Username=myoteluser;Password=myotelpass123;"
    
    dotnet ef migrations add "$migration_name" --verbose
    
    if [ $? -eq 0 ]; then
        echo -e "${GREEN}✅ Migration created successfully${NC}"
        echo -e "${BLUE}💡 Don't forget to run migrations to apply changes${NC}"
    else
        echo -e "${RED}❌ Failed to create migration${NC}"
        exit 1
    fi
    
    cd ../..
}

# Parse command line arguments
case "${1:-}" in
    "container"|"c")
        run_migrations_in_container
        ;;
    "local"|"l")
        run_migrations_locally
        ;;
    "status"|"s")
        check_database_status
        ;;
    "reset"|"r")
        reset_database
        ;;
    "create")
        create_migration "$2"
        ;;
    "help"|"h"|"")
        echo "Usage: $0 <command> [options]"
        echo ""
        echo "Commands:"
        echo "  container, c     - Run migrations using the API container (recommended)"
        echo "  local, l         - Run migrations using local .NET CLI"
        echo "  status, s        - Check database and migration status"
        echo "  reset, r         - Reset database (WARNING: destructive!)"
        echo "  create <name>    - Create a new migration"
        echo "  help, h          - Show this help message"
        echo ""
        echo "Examples:"
        echo "  $0 container           # Run migrations in container"
        echo "  $0 status              # Check database status"
        echo "  $0 create AddUserTable # Create new migration"
        echo ""
        echo -e "${BLUE}💡 Recommended: Use 'container' method for consistency${NC}"
        ;;
    *)
        echo -e "${RED}❌ Unknown command: $1${NC}"
        echo -e "${YELLOW}💡 Use '$0 help' to see available commands${NC}"
        exit 1
        ;;
esac
