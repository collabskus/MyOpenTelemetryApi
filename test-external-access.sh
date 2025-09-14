#!/bin/bash

# test-external-access.sh - Test external network access to the services

set -e

# Colors for output
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
BLUE='\033[0;34m'
NC='\033[0m' # No Color

echo -e "${BLUE}🌐 Testing External Network Access${NC}"
echo "====================================="

# Function to get the machine's IP addresses
get_ip_addresses() {
    echo -e "${BLUE}📡 Detecting network interfaces...${NC}"
    
    # Get all IP addresses (excluding loopback)
    IPS=$(ip -4 addr show | grep -E 'inet [0-9]' | grep -v '127.0.0.1' | awk '{print $2}' | cut -d'/' -f1)
    
    if [ -z "$IPS" ]; then
        echo -e "${RED}❌ No network interfaces found${NC}"
        return 1
    fi
    
    echo -e "${GREEN}Found network interfaces:${NC}"
    for ip in $IPS; do
        # Get interface name
        INTERFACE=$(ip route get $ip | grep -oP 'dev \K\S+' | head -1)
        echo -e "${YELLOW}  📍 $ip${NC} (${INTERFACE:-unknown})"
    done
    
    echo ""
}

# Function to test port binding
test_port_binding() {
    local port=$1
    local service_name=$2
    
    echo -e "${BLUE}🔍 Testing port $port ($service_name)...${NC}"
    
    # Check if port is bound to 0.0.0.0
    if netstat -tlnp 2>/dev/null | grep ":$port " | grep -q "0.0.0.0:$port"; then
        echo -e "${GREEN}✅ Port $port is bound to 0.0.0.0 (externally accessible)${NC}"
        return 0
    elif netstat -tlnp 2>/dev/null | grep -q ":$port "; then
        echo -e "${YELLOW}⚠️  Port $port is bound but may not be externally accessible${NC}"
        netstat -tlnp 2>/dev/null | grep ":$port "
        return 1
    else
        echo -e "${RED}❌ Port $port is not bound${NC}"
        return 1
    fi
}

# Function to test external access
test_external_access() {
    local ip=$1
    local port=$2
    local path=$3
    local service_name=$4
    
    echo -e "${BLUE}🧪 Testing $service_name access: http://$ip:$port$path${NC}"
    
    if curl -s --connect-timeout 5 --max-time 10 "http://$ip:$port$path" > /dev/null 2>&1; then
        echo -e "${GREEN}✅ SUCCESS: http://$ip:$port$path${NC}"
        return 0
    else
        echo -e "${RED}❌ FAILED: http://$ip:$port$path${NC}"
        return 1
    fi
}

# Function to check firewall status
check_firewall() {
    echo -e "${BLUE}🔥 Checking firewall status...${NC}"
    
    # Check ufw (Ubuntu/Debian)
    if command -v ufw &> /dev/null; then
        UFW_STATUS=$(ufw status 2>/dev/null || echo "inactive")
        if echo "$UFW_STATUS" | grep -q "Status: active"; then
            echo -e "${YELLOW}⚠️  UFW firewall is active${NC}"
            echo -e "${BLUE}Firewall rules for our ports:${NC}"
            ufw status | grep -E "(5174|5432)" || echo -e "${RED}No rules found for ports 5174/5432${NC}"
        else
            echo -e "${GREEN}✅ UFW firewall is inactive${NC}"
        fi
    fi
    
    # Check iptables
    if command -v iptables &> /dev/null; then
        if iptables -L INPUT | grep -q "DROP\|REJECT"; then
            echo -e "${YELLOW}⚠️  iptables has restrictive rules${NC}"
        else
            echo -e "${GREEN}✅ iptables appears permissive${NC}"
        fi
    fi
    
    echo ""
}

# Function to show connection examples
show_connection_examples() {
    echo -e "${GREEN}🎯 External Access URLs:${NC}"
    echo "========================"
    
    for ip in $IPS; do
        echo -e "${BLUE}From $ip:${NC}"
        echo -e "${YELLOW}  🌐 API Health Check:${NC}    http://$ip:5174/api/health"
        echo -e "${YELLOW}  🌐 API Root Page:${NC}       http://$ip:5174/"
        echo -e "${YELLOW}  🌐 API Contacts:${NC}        http://$ip:5174/api/contacts"
        echo -e "${YELLOW}  🗄️  PostgreSQL:${NC}         $ip:5432 (username: myoteluser, password: myotelpass123)"
        echo ""
    done
    
    echo -e "${BLUE}💡 Example curl commands from external machine:${NC}"
    FIRST_IP=$(echo $IPS | awk '{print $1}')
    echo -e "${YELLOW}curl http://$FIRST_IP:5174/api/health${NC}"
    echo -e "${YELLOW}curl http://$FIRST_IP:5174/api/contacts${NC}"
    echo ""
}

# Function to create test endpoints
test_api_endpoints() {
    local ip=$1
    
    echo -e "${BLUE}🧪 Testing API endpoints on $ip...${NC}"
    
    # Test health endpoint
    if test_external_access "$ip" "5174" "/api/health" "Health Check"; then
        # Test if we can get JSON response
        HEALTH_RESPONSE=$(curl -s "http://$ip:5174/api/health" 2>/dev/null)
        if echo "$HEALTH_RESPONSE" | jq . &>/dev/null; then
            echo -e "${GREEN}   📊 JSON Response: $(echo "$HEALTH_RESPONSE" | jq -c .)${NC}"
        fi
    fi
    
    # Test root endpoint
    test_external_access "$ip" "5174" "/" "Root Page"
    
    # Test contacts endpoint
    if test_external_access "$ip" "5174" "/api/contacts" "Contacts API"; then
        CONTACTS_RESPONSE=$(curl -s "http://$ip:5174/api/contacts" 2>/dev/null)
        if echo "$CONTACTS_RESPONSE" | jq . &>/dev/null; then
            CONTACT_COUNT=$(echo "$CONTACTS_RESPONSE" | jq '. | length')
            echo -e "${GREEN}   📊 Found $CONTACT_COUNT contacts${NC}"
        fi
    fi
    
    echo ""
}

# Main execution
main() {
    # Get IP addresses
    if ! get_ip_addresses; then
        exit 1
    fi
    
    # Check firewall
    check_firewall
    
    # Check port bindings
    echo -e "${BLUE}🔍 Checking port bindings...${NC}"
    API_PORT_OK=false
    DB_PORT_OK=false
    
    if test_port_binding "5174" "API"; then
        API_PORT_OK=true
    fi
    
    if test_port_binding "5432" "PostgreSQL"; then
        DB_PORT_OK=true
    fi
    
    echo ""
    
    # Test external access for each IP
    for ip in $IPS; do
        if [ "$API_PORT_OK" = true ]; then
            test_api_endpoints "$ip"
        else
            echo -e "${RED}❌ Skipping API tests for $ip - port 5174 not accessible${NC}"
        fi
    done
    
    # Show connection examples
    show_connection_examples
    
    # Troubleshooting tips
    echo -e "${BLUE}🛠️  Troubleshooting Tips:${NC}"
    echo "========================"
    
    if [ "$API_PORT_OK" = false ]; then
        echo -e "${RED}API Port Issue:${NC}"
        echo -e "${YELLOW}  1. Check if containers are running: podman ps${NC}"
        echo -e "${YELLOW}  2. Check container logs: podman logs myotel-api${NC}"
        echo -e "${YELLOW}  3. Restart services: ./setup-podman.sh${NC}"
        echo ""
    fi
    
    echo -e "${BLUE}Firewall Configuration:${NC}"
    echo -e "${YELLOW}  # Allow API port through UFW${NC}"
    echo -e "${YELLOW}  sudo ufw allow 5174/tcp${NC}"
    echo -e "${YELLOW}  # Allow PostgreSQL port (if needed externally)${NC}"
    echo -e "${YELLOW}  sudo ufw allow 5432/tcp${NC}"
    echo ""
    
    echo -e "${BLUE}Container Port Verification:${NC}"
    echo -e "${YELLOW}  podman port myotel-api${NC}"
    echo -e "${YELLOW}  podman port myotel-postgres${NC}"
}

# Run main function
main
