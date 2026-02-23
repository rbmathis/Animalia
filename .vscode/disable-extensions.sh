#!/bin/bash
#
# disable-extensions.sh
#
# Disables extensions listed in extensions.json for this workspace.
#
# Usage:
#   ./disable-extensions.sh          # Disable for this workspace only
#   ./disable-extensions.sh --global # Disable extensions globally
#

set -e

SCRIPT_DIR="$(cd "$(dirname "${BASH_SOURCE[0]}")" && pwd)"
EXTENSIONS_JSON="$SCRIPT_DIR/extensions.json"

# Colors
RED='\033[0;31m'
GREEN='\033[0;32m'
YELLOW='\033[1;33m'
CYAN='\033[0;36m'
GRAY='\033[0;37m'
NC='\033[0m' # No Color

# Check for jq
if ! command -v jq &> /dev/null; then
    echo -e "${RED}Error: jq is required but not installed.${NC}"
    echo "Install with: sudo apt install jq  (or brew install jq on macOS)"
    exit 1
fi

# Check for python3
if ! command -v python3 &> /dev/null; then
    echo -e "${RED}Error: python3 is required but not installed.${NC}"
    exit 1
fi

# Check extensions.json exists
if [[ ! -f "$EXTENSIONS_JSON" ]]; then
    echo -e "${RED}Error: extensions.json not found at: $EXTENSIONS_JSON${NC}"
    exit 1
fi

# Read unwanted extensions
EXTENSIONS=$(jq -r '.unwantedRecommendations[]?' "$EXTENSIONS_JSON")

if [[ -z "$EXTENSIONS" ]]; then
    echo -e "${YELLOW}No extensions listed in unwantedRecommendations.${NC}"
    exit 0
fi

EXT_COUNT=$(echo "$EXTENSIONS" | wc -l)
echo -e "${CYAN}Found $EXT_COUNT extensions to disable:${NC}"
echo "$EXTENSIONS" | while read -r ext; do
    echo -e "  ${GRAY}- $ext${NC}"
done
echo ""

# Determine VS Code config path based on OS
if [[ "$OSTYPE" == "darwin"* ]]; then
    VSCODE_CONFIG="$HOME/Library/Application Support/Code/User"
else
    VSCODE_CONFIG="$HOME/.config/Code/User"
fi

WORKSPACE_STORAGE="$VSCODE_CONFIG/workspaceStorage"

if [[ "$1" == "--global" || "$1" == "-g" ]]; then
    echo -e "${YELLOW}Disabling extensions globally via VS Code CLI...${NC}"
    echo "$EXTENSIONS" | while read -r ext; do
        echo -e "  ${GRAY}Disabling: $ext${NC}"
        code --disable-extension "$ext" 2>/dev/null || true
    done
    echo -e "\n${GREEN}Done! Restart VS Code for changes to take effect.${NC}"
else
    # Find workspace storage folder
    WORKSPACE_FOLDER="$(dirname "$SCRIPT_DIR")"
    
    # URL encode the workspace path
    WORKSPACE_URI=$(python3 -c "import urllib.parse; print(urllib.parse.quote('$WORKSPACE_FOLDER', safe=''))")
    
    TARGET_STORAGE=""
    
    if [[ -d "$WORKSPACE_STORAGE" ]]; then
        for dir in "$WORKSPACE_STORAGE"/*/; do
            WS_JSON="$dir/workspace.json"
            if [[ -f "$WS_JSON" ]]; then
                FOLDER_URI=$(jq -r '.folder // empty' "$WS_JSON" 2>/dev/null)
                if [[ -n "$FOLDER_URI" && "$FOLDER_URI" == *"$WORKSPACE_FOLDER"* ]]; then
                    TARGET_STORAGE="${dir%/}"
                    break
                fi
            fi
        done
    fi
    
    if [[ -z "$TARGET_STORAGE" ]]; then
        echo -e "${RED}Could not find workspace storage folder.${NC}"
        echo -e "${YELLOW}Open this workspace in VS Code first, or use --global to disable globally.${NC}"
        exit 1
    fi
    
    DB_PATH="$TARGET_STORAGE/state.vscdb"
    
    if [[ ! -f "$DB_PATH" ]]; then
        echo -e "${RED}VS Code state database not found at: $DB_PATH${NC}"
        exit 1
    fi
    
    echo -e "${GREEN}Workspace storage found: $TARGET_STORAGE${NC}"
    echo -e "${YELLOW}Updating disabled extensions in workspace...${NC}"
    
    # Build JSON array
    DISABLED_JSON=$(echo "$EXTENSIONS" | jq -R -s 'split("\n") | map(select(length > 0)) | map({id: .})')
    
    # Create temp Python script
    TEMP_PY=$(mktemp)
    cat > "$TEMP_PY" << 'PYEOF'
import sqlite3
import sys
import json

db_path = sys.argv[1]
disabled_json = sys.argv[2]

conn = sqlite3.connect(db_path)
cursor = conn.cursor()

# Check if key exists
cursor.execute("SELECT COUNT(*) FROM ItemTable WHERE key = 'extensionsIdentifiers/disabled'")
exists = cursor.fetchone()[0] > 0

if exists:
    cursor.execute("UPDATE ItemTable SET value = ? WHERE key = 'extensionsIdentifiers/disabled'", (disabled_json,))
else:
    cursor.execute("INSERT INTO ItemTable (key, value) VALUES ('extensionsIdentifiers/disabled', ?)", (disabled_json,))

conn.commit()
conn.close()
print("Database updated successfully")
PYEOF
    
    # Make a backup and update
    TEMP_DB=$(mktemp)
    cp "$DB_PATH" "$TEMP_DB"
    
    if python3 "$TEMP_PY" "$TEMP_DB" "$DISABLED_JSON"; then
        cp "$TEMP_DB" "$DB_PATH"
        echo -e "\n${GREEN}Successfully disabled $EXT_COUNT extensions for this workspace!${NC}"
        echo -e "${CYAN}Restart VS Code (or reload window) for changes to take effect.${NC}"
    else
        echo -e "${RED}Error updating database.${NC}"
        echo -e "${YELLOW}Make sure VS Code is closed.${NC}"
        exit 1
    fi
    
    # Cleanup
    rm -f "$TEMP_PY" "$TEMP_DB"
fi
