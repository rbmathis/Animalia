#!/usr/bin/env python3
"""
Targeted breadcrumb generator - processes specific paths without full tree scan.

Usage:
    python generate_breadcrumbs_targeted.py
"""

import os
import re
from pathlib import Path
from datetime import datetime
from typing import Dict, List, Optional, Any

# Target paths for breadcrumb generation (relative to repo root)
TARGET_PATHS = [
    # Top levels
    "root",
    "root/Metazoa",
    "root/Metazoa/Chordata",
    "root/Metazoa/Chordata/Mammalia",
    # Orders
    "root/Metazoa/Chordata/Mammalia/Carnivora",
    "root/Metazoa/Chordata/Mammalia/Primates",
    "root/Metazoa/Chordata/Mammalia/Rodentia",
    "root/Metazoa/Chordata/Mammalia/Cetacea",
    "root/Metazoa/Chordata/Mammalia/Artiodactyla",
    # Priority families
    "root/Metazoa/Chordata/Mammalia/Carnivora/Canidae",
    "root/Metazoa/Chordata/Mammalia/Carnivora/Felidae",
    "root/Metazoa/Chordata/Mammalia/Carnivora/Ursidae",
    "root/Metazoa/Chordata/Mammalia/Primates/Hominidae",
    # Priority genera (examples from copilot-instructions)
    "root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis",
    "root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Vulpes",
    "root/Metazoa/Chordata/Mammalia/Carnivora/Felidae/Panthera",
    "root/Metazoa/Chordata/Mammalia/Carnivora/Ursidae/Ursus",
    "root/Metazoa/Chordata/Mammalia/Primates/Hominidae/Homo",
]

# Conservation status normalization
CONSERVATION_STATUS_MAP = {
    'Least Concern': 'least-concern',
    'Near Threatened': 'near-threatened',
    'Vulnerable': 'vulnerable',
    'Endangered': 'endangered',
    'Critically Endangered': 'critically-endangered',
}


def parse_cs_file(filepath: Path) -> Optional[Dict[str, Any]]:
    """Parse a C# file and extract taxonomy data."""
    try:
        content = filepath.read_text(encoding='utf-8')
    except Exception:
        return None

    data = {'filepath': filepath, 'filename': filepath.name}

    patterns = {
        'tax_id': re.compile(r'(?:override\s+)?int\s+TaxId\s*=>\s*(\d+)'),
        'rank': re.compile(r'TaxonomicRank\s*=>\s*"(\w+)"'),
        'species_name': re.compile(r'SpeciesName\s*=>\s*"([^"]+)"'),
        'common_name': re.compile(r'CommonName\s*=>\s*"([^"]*)"'),
        'conservation': re.compile(r'ConservationStatus\s*=>\s*"([^"]+)"'),
        'is_enriched': re.compile(r'IsEnriched\s*=\s*(true|false)'),
        'characteristics': re.compile(r'(?:Species|Genus|Family)Characteristics\s*=>\s*new\[\]\s*\{([^}]+)\}', re.DOTALL),
    }

    for key, pattern in patterns.items():
        match = pattern.search(content)
        if match:
            if key == 'characteristics':
                chars_str = match.group(1)
                chars = re.findall(r'"([^"]+)"', chars_str)
                data[key] = chars
            elif key == 'is_enriched':
                data[key] = match.group(1).lower() == 'true'
            elif key == 'tax_id':
                data[key] = int(match.group(1))
            else:
                data[key] = match.group(1)

    return data


def get_immediate_children(path: Path) -> List[Path]:
    """Get immediate subdirectories."""
    if not path.exists():
        return []
    return [p for p in sorted(path.iterdir()) if p.is_dir() and not p.name.startswith('.')]


def get_species_in_folder(path: Path) -> List[Dict[str, Any]]:
    """Get all species files directly in this folder (not recursive)."""
    species = []
    for cs_file in path.glob("*.cs"):
        if cs_file.name.startswith('I'):  # Skip interfaces
            continue
        data = parse_cs_file(cs_file)
        if data and data.get('rank') == 'species':
            species.append(data)
    return species


def get_folder_data(path: Path) -> Dict[str, Any]:
    """Get the base class data for this folder."""
    for cs_file in path.glob("*.cs"):
        if cs_file.name.startswith('I'):
            continue
        data = parse_cs_file(cs_file)
        if data and data.get('rank') in ['genus', 'family', 'order', 'class', 'phylum', 'kingdom']:
            return data
    return {}


def generate_breadcrumb(path: Path):
    """Generate breadcrumb.md for a specific path."""
    from datetime import date
    
    if not path.exists():
        print(f"Skipping (not found): {path}")
        return

    name = path.name
    children = get_immediate_children(path)
    species = get_species_in_folder(path)
    folder_data = get_folder_data(path)

    rank = folder_data.get('rank', infer_rank(path))
    tax_id = folder_data.get('tax_id')
    characteristics = folder_data.get('characteristics', [])

    # Collect conservation statuses from direct species
    conservation_tags = set()
    for sp in species:
        cons = sp.get('conservation', '')
        if cons in CONSERVATION_STATUS_MAP:
            conservation_tags.add(CONSERVATION_STATUS_MAP[cons])

    # Collect all tags as flat list
    all_tags = [name.lower(), rank]
    all_tags.extend(sorted(conservation_tags))
    
    # Get related (siblings) - but only for taxa inside root/Metazoa
    parent_path = path.parent
    siblings = []
    if parent_path.exists() and 'Metazoa' in str(path):
        siblings = [p.name for p in get_immediate_children(parent_path) 
                    if p.name != name and not p.name.startswith('unclassified')][:3]

    # Build frontmatter (breadcrumbs-compatible order)
    lines = []
    lines.append('---')
    lines.append(f'title: "{format_title(name)}"')
    lines.append(f'description: "{generate_description(name, rank, len(children), len(species))}"')
    lines.append(f'category: "taxonomy/{rank}"')
    
    # Tags as flat array
    tags_str = ', '.join(f'"{t}"' for t in all_tags[:8])
    lines.append(f'tags: [{tags_str}]')
    
    # Status and updated
    lines.append('status: "Living"')
    lines.append(f'updated: "{date.today().isoformat()}"')
    
    # Related (siblings) as inline array
    if siblings:
        related_str = ', '.join(f'"../{sib}/breadcrumb.md"' for sib in siblings)
        lines.append(f'related: [{related_str}]')
    else:
        lines.append('related: []')
    
    # Links_from (backlinks)
    if name != 'root':
        lines.append('links_from: ["../breadcrumb.md"]')
    else:
        lines.append('links_from: []')
    
    # Taxonomy-specific fields
    lines.append(f'rank: "{rank}"')
    if tax_id:
        lines.append(f'taxId: {tax_id}')
    if name != 'root':
        lines.append('parent: "../breadcrumb.md"')
    if children:
        lines.append(f'children_count: {len(children)}')
    lines.append(f'species_count: {len(species)}')

    # Characteristics
    if characteristics:
        lines.append('characteristics:')
        for char in characteristics[:5]:
            lines.append(f'  - "{char}"')

    # Children list
    if children and rank in ['kingdom', 'phylum', 'class', 'order', 'family']:
        key = 'genera' if rank == 'family' else 'children'
        lines.append(f'{key}:')
        for child in children[:10]:
            lines.append(f'  - path: "{child.name}/breadcrumb.md"')
            lines.append(f'    name: "{child.name}"')

    # Species list (for genus level)
    if rank == 'genus' and species:
        lines.append('species:')
        for sp in sorted(species, key=lambda s: s.get('species_name', ''))[:20]:
            lines.append(f'  - file: "{sp.get("filename", "")}"')
            lines.append(f'    name: "{sp.get("species_name", "")}"')
            lines.append(f'    common_name: "{sp.get("common_name", "")}"')
            lines.append(f'    conservation: "{sp.get("conservation", "Unknown")}"')
            lines.append(f'    enriched: {str(sp.get("is_enriched", False)).lower()}')

    lines.append('---')
    lines.append('')

    # Build body
    lines.append(f'# {format_title(name)}')
    lines.append('')
    lines.append(generate_description(name, rank, len(children), len(species)))
    lines.append('')
    lines.append('## Overview')
    lines.append('')
    lines.append(f'- **Rank**: {rank}')
    if tax_id:
        lines.append(f'- **NCBI TaxId**: {tax_id}')
    lines.append(f'- **Direct Children**: {len(children)}')
    lines.append(f'- **Species in folder**: {len(species)}')
    lines.append('')

    if characteristics:
        lines.append('## Characteristics')
        lines.append('')
        for char in characteristics:
            lines.append(f'- {char}')
        lines.append('')

    if children:
        child_type = 'Genera' if rank == 'family' else 'Sub-taxa'
        lines.append(f'## {child_type}')
        lines.append('')
        for child in children:
            lines.append(f'- [{child.name}]({child.name}/breadcrumb.md)')
        lines.append('')

    if species:
        lines.append('## Species')
        lines.append('')
        lines.append('| Species | Common Name | Conservation |')
        lines.append('|---------|-------------|--------------|')
        for sp in sorted(species, key=lambda s: s.get('species_name', ''))[:15]:
            name_sp = sp.get('species_name', 'Unknown')
            common = sp.get('common_name', '')
            cons = sp.get('conservation', 'Unknown')
            lines.append(f'| {name_sp} | {common} | {cons} |')
        lines.append('')

    lines.append('## Navigation')
    lines.append('')
    lines.append('- [↑ Parent](../breadcrumb.md)')
    if children:
        lines.append(f'- [↓ First Child: {children[0].name}]({children[0].name}/breadcrumb.md)')
    lines.append('')

    content = '\n'.join(lines)

    # Write file
    breadcrumb_path = path / 'breadcrumb.md'
    breadcrumb_path.write_text(content, encoding='utf-8')
    print(f'Created: {breadcrumb_path}')


def infer_rank(path: Path) -> str:
    """Infer rank from folder depth."""
    parts = path.parts
    if 'Metazoa' not in parts:
        return 'kingdom'
    metazoa_idx = parts.index('Metazoa')
    depth = len(parts) - metazoa_idx - 1
    ranks = ['phylum', 'class', 'order', 'family', 'genus']
    return ranks[min(depth, len(ranks) - 1)]


def format_title(name: str) -> str:
    """Format a human-readable title."""
    descriptions = {
        'root': 'Animalia (Animal Kingdom)',
        'Metazoa': 'Metazoa (Multicellular Animals)',
        'Chordata': 'Chordata (Chordates)',
        'Mammalia': 'Mammalia (Mammals)',
        'Carnivora': 'Carnivora (Carnivorans)',
        'Primates': 'Primates (Primates)',
        'Canidae': 'Canidae (Dog Family)',
        'Felidae': 'Felidae (Cat Family)',
        'Ursidae': 'Ursidae (Bear Family)',
        'Hominidae': 'Hominidae (Great Apes)',
    }
    return descriptions.get(name, name)


def generate_description(name: str, rank: str, children_count: int, species_count: int) -> str:
    """Generate a description."""
    if rank == 'family':
        return f"Family containing {children_count} genera."
    elif rank == 'genus':
        return f"Genus containing {species_count} species."
    elif rank == 'order':
        return f"Order containing {children_count} families."
    elif rank == 'class':
        return f"Class containing {children_count} orders."
    else:
        return f"Taxonomic {rank} with {children_count} sub-taxa."


def main():
    print("Generating targeted breadcrumbs...")
    print(f"Processing {len(TARGET_PATHS)} paths\n")

    for target in TARGET_PATHS:
        path = Path(target)
        generate_breadcrumb(path)

    print(f"\nDone! Generated {len(TARGET_PATHS)} breadcrumbs.")


if __name__ == '__main__':
    main()
