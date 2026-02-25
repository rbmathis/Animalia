#!/usr/bin/env python3
"""
Migrates breadcrumb.md files from verbose schema to lean schema v2.

Usage:
    python migrate-breadcrumbs.py --dry-run                    # Preview all changes
    python migrate-breadcrumbs.py --file path/breadcrumb.md    # Single file
    python migrate-breadcrumbs.py                              # Migrate all
"""

import os
import re
import sys
import argparse
from pathlib import Path
from typing import Dict, List, Any, Optional, Tuple

# Fix Windows console encoding
if sys.platform == 'win32':
    sys.stdout.reconfigure(encoding='utf-8', errors='replace')

# IUCN conservation status mapping
CONSERVATION_MAP = {
    "Least Concern": "LC",
    "Near Threatened": "NT",
    "Vulnerable": "VU",
    "Endangered": "EN",
    "Endangered status": "EN",
    "Critically Endangered": "CR",
    "Extinct in Wild": "EW",
    "Extinct": "EX",
    "Data Deficient": "DD",
    "Unknown": "UK",
    # Already codes
    "LC": "LC", "NT": "NT", "VU": "VU", "EN": "EN",
    "CR": "CR", "EW": "EW", "EX": "EX", "DD": "DD", "UK": "UK"
}

def get_conservation_code(status: str) -> str:
    return CONSERVATION_MAP.get(status, "DD")

def parse_frontmatter(content: str) -> Tuple[Dict, str]:
    """Parse YAML frontmatter from markdown content."""
    match = re.match(r'^---\s*\n(.*?)\n---\s*\n?(.*)', content, re.DOTALL)
    if not match:
        return {}, content

    fm_text = match.group(1)
    body = match.group(2)

    # Simple YAML parser for our specific structure
    frontmatter = {}
    lines = fm_text.split('\n')
    i = 0

    while i < len(lines):
        line = lines[i]
        if not line.strip():
            i += 1
            continue

        # Match key: value or key:
        m = re.match(r'^([a-z_]+):\s*(.*)?$', line)
        if m:
            key = m.group(1)
            value = (m.group(2) or '').strip()

            # Inline array
            if value.startswith('[') and value.endswith(']'):
                items = value[1:-1].split(',')
                frontmatter[key] = [item.strip().strip('"').strip("'") for item in items if item.strip()]
                i += 1
            # Multi-line array
            elif value == '' or value is None:
                i += 1
                array_items = []
                current_item = None

                while i < len(lines) and (lines[i].startswith('  ') or lines[i].startswith('\t') or lines[i].strip() == ''):
                    arr_line = lines[i]
                    if arr_line.strip() == '':
                        i += 1
                        continue

                    # New array item
                    m2 = re.match(r'^  - (.+)$', arr_line)
                    if m2:
                        if current_item is not None:
                            array_items.append(current_item)

                        item_value = m2.group(1).strip()
                        # Check if it's a key: value
                        m3 = re.match(r'^([a-z_]+):\s*(.*)$', item_value)
                        if m3:
                            current_item = {m3.group(1): m3.group(2).strip().strip('"').strip("'")}
                        else:
                            current_item = item_value.strip('"').strip("'")
                        i += 1
                    # Continuation of object item
                    elif re.match(r'^    ([a-z_]+):', arr_line):
                        m4 = re.match(r'^    ([a-z_]+):\s*(.*)$', arr_line)
                        if m4 and isinstance(current_item, dict):
                            val = m4.group(2).strip().strip('"').strip("'")
                            if val == 'true':
                                val = True
                            elif val == 'false':
                                val = False
                            current_item[m4.group(1)] = val
                        i += 1
                    else:
                        break

                if current_item is not None:
                    array_items.append(current_item)
                frontmatter[key] = array_items
            else:
                # Simple value
                frontmatter[key] = value.strip('"').strip("'")
                i += 1
        else:
            i += 1

    return frontmatter, body

def format_yaml_value(value: Any, indent: int = 0) -> str:
    """Format a value as YAML."""
    ind = "  " * indent

    if isinstance(value, bool):
        return "true" if value else "false"
    elif isinstance(value, (int, float)):
        return str(value)
    elif isinstance(value, str):
        # Quote if needed
        if any(c in value for c in ':#[]{}|>&*!') or value.startswith(' ') or value.endswith(' '):
            return f'"{value}"'
        return value
    elif isinstance(value, list):
        if not value:
            return "[]"
        # Check if all simple
        all_simple = all(not isinstance(item, dict) for item in value)
        if all_simple and len(value) <= 10:
            items = [format_yaml_value(v) for v in value]
            return f"[{', '.join(items)}]"
        else:
            lines = []
            for item in value:
                if isinstance(item, dict):
                    first = True
                    for k, v in item.items():
                        if first:
                            lines.append(f"{ind}  - {k}: {format_yaml_value(v)}")
                            first = False
                        else:
                            lines.append(f"{ind}    {k}: {format_yaml_value(v)}")
                else:
                    lines.append(f"{ind}  - {format_yaml_value(item)}")
            return "\n" + "\n".join(lines)
    elif isinstance(value, dict):
        lines = []
        for k, v in value.items():
            formatted = format_yaml_value(v, indent + 1)
            if formatted.startswith("\n"):
                lines.append(f"{ind}  {k}:{formatted}")
            else:
                lines.append(f"{ind}  {k}: {formatted}")
        return "\n" + "\n".join(lines)
    return str(value)

def build_lean_yaml(frontmatter: Dict, species_data: Optional[Dict], genera_list: Optional[List], pet_genera_list: Optional[List]) -> str:
    """Build lean YAML frontmatter."""
    lines = ["---"]

    # Standard fields in order
    ordered_fields = [
        "title", "description", "category", "tags", "status", "updated",
        "related", "links_from", "rank", "taxId", "parent",
        "children_count", "species_count", "characteristics"
    ]

    for field in ordered_fields:
        if field in frontmatter:
            val = format_yaml_value(frontmatter[field])
            if val.startswith("\n"):
                lines.append(f"{field}:{val}")
            else:
                lines.append(f"{field}: {val}")

    # Species data
    if species_data:
        lines.append("species_data:")
        for key, entry in species_data.items():
            lines.append(f"  {key}:")
            for prop, val in entry.items():
                lines.append(f"    {prop}: {format_yaml_value(val)}")

    # Genera
    if genera_list:
        val = format_yaml_value(genera_list)
        lines.append(f"genera: {val}")

    # Pet genera
    if pet_genera_list:
        val = format_yaml_value(pet_genera_list)
        lines.append(f"pet_genera: {val}")

    # Keep endangered_species and pet_families if present
    for field in ["endangered_species", "pet_families"]:
        if field in frontmatter:
            val = format_yaml_value(frontmatter[field])
            if val.startswith("\n"):
                lines.append(f"{field}:{val}")
            else:
                lines.append(f"{field}: {val}")

    lines.append("---")
    return "\n".join(lines)

def migrate_breadcrumb(filepath: str, dry_run: bool = False) -> Dict:
    """Migrate a single breadcrumb file."""
    with open(filepath, 'r', encoding='utf-8') as f:
        content = f.read()

    frontmatter, body = parse_frontmatter(content)

    if not frontmatter:
        return {"path": filepath, "status": "no-frontmatter", "changes": []}

    if "species_data" in frontmatter:
        return {"path": filepath, "status": "already-migrated", "changes": []}

    changes = []
    species_data = None
    genera_list = None
    pet_genera_list = None

    # Convert species array to species_data
    if "species" in frontmatter and isinstance(frontmatter["species"], list):
        species = frontmatter["species"]
        if species and isinstance(species[0], dict):
            species_data = {}
            for sp in species:
                if "file" not in sp:
                    continue
                key = sp["file"].replace(".cs", "")
                entry = {}
                if "common_name" in sp:
                    entry["common_name"] = sp["common_name"]
                if "conservation" in sp:
                    entry["conservation"] = get_conservation_code(sp["conservation"])
                if sp.get("pet") is True:
                    entry["pet"] = True
                species_data[key] = entry

            changes.append(f"species -> species_data ({len(species_data)} entries)")
            del frontmatter["species"]

    # Convert genera array to simple list
    if "genera" in frontmatter and isinstance(frontmatter["genera"], list):
        genera = frontmatter["genera"]
        if genera and isinstance(genera[0], dict):
            genera_list = [g.get("name", "") for g in genera if "name" in g]
            changes.append(f"genera -> list ({len(genera_list)} items)")
            del frontmatter["genera"]
        else:
            genera_list = frontmatter["genera"]
            del frontmatter["genera"]

    # Convert pet_genera to simple list
    if "pet_genera" in frontmatter and isinstance(frontmatter["pet_genera"], list):
        pet_genera = frontmatter["pet_genera"]
        if pet_genera and isinstance(pet_genera[0], dict):
            pet_genera_list = [g.get("name", "") for g in pet_genera if "name" in g]
            changes.append(f"pet_genera -> list ({len(pet_genera_list)} items)")
            del frontmatter["pet_genera"]
        else:
            pet_genera_list = frontmatter["pet_genera"]
            del frontmatter["pet_genera"]

    if not changes:
        return {"path": filepath, "status": "no-changes", "changes": []}

    # Build new content
    new_yaml = build_lean_yaml(frontmatter, species_data, genera_list, pet_genera_list)
    new_content = new_yaml + "\n" + body

    if not dry_run:
        with open(filepath, 'w', encoding='utf-8') as f:
            f.write(new_content)

    status = "would-migrate" if dry_run else "migrated"
    return {"path": filepath, "status": status, "changes": changes}

def main():
    parser = argparse.ArgumentParser(description="Migrate breadcrumbs to lean schema v2")
    parser.add_argument("--dry-run", action="store_true", help="Preview changes without writing")
    parser.add_argument("--file", type=str, help="Process a single file")
    parser.add_argument("--path", type=str, default="root", help="Root path to process")
    args = parser.parse_args()

    # Find files
    if args.file:
        files = [args.file]
    else:
        files = list(Path(args.path).rglob("breadcrumb.md"))

    mode = "(DRY RUN)" if args.dry_run else ""
    print(f"\n📦 Breadcrumb Migration {mode}")
    print(f"Found {len(files)} breadcrumb file(s)\n")

    stats = {"total": 0, "migrated": 0, "already": 0, "no_changes": 0, "errors": 0}

    for filepath in files:
        stats["total"] += 1
        try:
            result = migrate_breadcrumb(str(filepath), dry_run=args.dry_run)
            rel_path = str(filepath)

            if result["status"] == "migrated":
                stats["migrated"] += 1
                print(f"✅ {rel_path}")
                for c in result["changes"]:
                    print(f"   {c}")
            elif result["status"] == "would-migrate":
                stats["migrated"] += 1
                print(f"🔄 {rel_path}")
                for c in result["changes"]:
                    print(f"   {c}")
            elif result["status"] == "already-migrated":
                stats["already"] += 1
                print(f"⏭️  {rel_path} (already migrated)")
            else:
                stats["no_changes"] += 1
                print(f"➖ {rel_path} (no changes needed)")
        except Exception as e:
            stats["errors"] += 1
            print(f"❌ {filepath}")
            print(f"   Error: {e}")

    print(f"\n📊 Summary")
    print(f"   Total:            {stats['total']}")
    print(f"   Migrated:         {stats['migrated']}")
    print(f"   Already migrated: {stats['already']}")
    print(f"   No changes:       {stats['no_changes']}")
    print(f"   Errors:           {stats['errors']}")

if __name__ == "__main__":
    main()
