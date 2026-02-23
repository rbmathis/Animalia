#!/usr/bin/env python3
"""
Breadcrumb Generator for Animal Kingdom Repository

Generates breadcrumb.md files with YAML frontmatter at key taxonomic levels
to enable efficient Copilot navigation of 160K+ files.

Usage:
    python generate_breadcrumbs.py [--dry-run] [--max-depth DEPTH] [--priority-only]

Options:
    --dry-run        Print what would be generated without writing files
    --max-depth N    Limit generation to N levels deep (default: all)
    --priority-only  Only generate for priority families (Canidae, Felidae, Ursidae)
"""

import os
import re
import argparse
from pathlib import Path
from datetime import datetime
from collections import defaultdict
from typing import Dict, List, Optional, Any

# Taxonomic rank hierarchy (depth from root)
RANK_ORDER = ['kingdom', 'phylum', 'subphylum', 'class', 'order', 'family', 'genus', 'species']

# Priority families for comprehensive genus coverage
PRIORITY_FAMILIES = ['Canidae', 'Felidae', 'Ursidae', 'Hominidae', 'Elephantidae', 'Equidae']

# Conservation status normalization
CONSERVATION_STATUS_MAP = {
    'Least Concern': 'least-concern',
    'Near Threatened': 'near-threatened', 
    'Vulnerable': 'vulnerable',
    'Endangered': 'endangered',
    'Critically Endangered': 'critically-endangered',
    'Extinct in Wild': 'extinct-in-wild',
    'Extinct': 'extinct',
    'Data Deficient': 'data-deficient',
}

# Diet keywords to infer diet type
DIET_KEYWORDS = {
    'carnivore': ['carnivore', 'meat', 'prey', 'hunt', 'predator'],
    'herbivore': ['herbivore', 'plant', 'graze', 'browse', 'vegetation'],
    'omnivore': ['omnivore', 'opportunistic', 'varied diet'],
    'insectivore': ['insectivore', 'insect', 'invertebrate'],
}

# Behavior keywords
BEHAVIOR_KEYWORDS = {
    'pack-hunter': ['pack', 'social hunt', 'cooperative'],
    'social': ['social', 'group', 'herd', 'pack', 'colony'],
    'solitary': ['solitary', 'alone', 'territorial'],
    'nocturnal': ['nocturnal', 'night'],
    'diurnal': ['diurnal', 'day'],
    'territorial': ['territorial', 'territory'],
}

# Habitat keywords  
HABITAT_KEYWORDS = {
    'arctic': ['arctic', 'polar', 'tundra', 'cold'],
    'temperate': ['temperate', 'forest', 'woodland'],
    'tropical': ['tropical', 'rainforest', 'jungle'],
    'desert': ['desert', 'arid', 'dry'],
    'marine': ['marine', 'ocean', 'sea', 'aquatic'],
    'freshwater': ['freshwater', 'river', 'lake', 'stream'],
    'grassland': ['grassland', 'savanna', 'prairie'],
    'mountain': ['mountain', 'alpine', 'highland'],
}


class CSharpParser:
    """Parser for extracting data from C# taxonomy files."""
    
    # Regex patterns for extracting properties from C# files
    PATTERNS = {
        'namespace': re.compile(r'namespace\s+([\w.]+);?'),
        'class': re.compile(r'public\s+(?:abstract\s+)?class\s+(\w+)\s*:\s*(\w+)'),
        'tax_id': re.compile(r'(?:override\s+)?int\s+TaxId\s*=>\s*(\d+)'),
        'rank': re.compile(r'TaxonomicRank\s*=>\s*"(\w+)"'),
        'species_name': re.compile(r'SpeciesName\s*=>\s*"([^"]+)"'),
        'common_name': re.compile(r'CommonName\s*=>\s*"([^"]*)"'),
        'conservation': re.compile(r'ConservationStatus\s*=>\s*"([^"]+)"'),
        'is_enriched': re.compile(r'IsEnriched\s*=\s*(true|false)'),
        'lifespan': re.compile(r'AverageLifespanYears\s*=>\s*([\d.]+)'),
        'reproduction': re.compile(r'ReproductionMethod\s*=>\s*"([^"]+)"'),
        'scientific_name': re.compile(r'ScientificName\s*=>\s*"([^"]+)"'),
        'characteristics': re.compile(r'(?:Species|Genus|Family)Characteristics\s*=>\s*new\[\]\s*\{([^}]+)\}', re.DOTALL),
    }
    
    @classmethod
    def parse_file(cls, filepath: Path) -> Optional[Dict[str, Any]]:
        """Parse a C# file and extract taxonomy data."""
        try:
            content = filepath.read_text(encoding='utf-8')
        except Exception:
            return None
            
        data = {'filepath': filepath, 'filename': filepath.name}
        
        for key, pattern in cls.PATTERNS.items():
            match = pattern.search(content)
            if match:
                if key == 'characteristics':
                    # Parse string array
                    chars_str = match.group(1)
                    chars = re.findall(r'"([^"]+)"', chars_str)
                    data[key] = chars
                elif key == 'is_enriched':
                    data[key] = match.group(1).lower() == 'true'
                elif key == 'tax_id':
                    data[key] = int(match.group(1))
                elif key == 'lifespan':
                    data[key] = float(match.group(1))
                elif key == 'class':
                    data['class_name'] = match.group(1)
                    data['parent_class'] = match.group(2)
                else:
                    data[key] = match.group(1)
        
        return data


class TaxonomyNode:
    """Represents a node in the taxonomy tree."""
    
    def __init__(self, path: Path, name: str, parent: Optional['TaxonomyNode'] = None):
        self.path = path
        self.name = name
        self.parent = parent
        self.children: List['TaxonomyNode'] = []
        self.species: List[Dict[str, Any]] = []
        self.data: Dict[str, Any] = {}
        self.rank: Optional[str] = None
        self.tax_id: Optional[int] = None
        
    def add_child(self, child: 'TaxonomyNode'):
        self.children.append(child)
        
    def add_species(self, species_data: Dict[str, Any]):
        self.species.append(species_data)
        
    @property
    def all_species(self) -> List[Dict[str, Any]]:
        """Get all species in this node and descendants."""
        result = list(self.species)
        for child in self.children:
            result.extend(child.all_species)
        return result
    
    @property
    def species_count(self) -> int:
        return len(self.all_species)
    
    @property
    def depth(self) -> int:
        """Distance from root."""
        if self.parent is None:
            return 0
        return self.parent.depth + 1


class BreadcrumbGenerator:
    """Main generator class for breadcrumb.md files."""
    
    def __init__(self, root_path: Path, dry_run: bool = False, max_depth: Optional[int] = None,
                 priority_only: bool = False):
        self.root_path = root_path
        self.dry_run = dry_run
        self.max_depth = max_depth
        self.priority_only = priority_only
        self.stats = defaultdict(int)
        
    def generate(self):
        """Main entry point - generate all breadcrumbs."""
        print(f"Scanning taxonomy from: {self.root_path}")
        
        # Build taxonomy tree
        tree = self._build_tree(self.root_path)
        
        # Generate breadcrumbs
        self._generate_breadcrumbs(tree)
        
        # Print stats
        print("\n=== Generation Complete ===")
        for key, value in sorted(self.stats.items()):
            print(f"  {key}: {value}")
            
    def _build_tree(self, path: Path, parent: Optional[TaxonomyNode] = None) -> TaxonomyNode:
        """Recursively build taxonomy tree from folder structure."""
        node = TaxonomyNode(path, path.name, parent)
        
        # Parse any .cs files in this folder
        cs_files = list(path.glob("*.cs"))
        
        for cs_file in cs_files:
            data = CSharpParser.parse_file(cs_file)
            if not data:
                continue
                
            rank = data.get('rank', '').lower()
            
            if rank == 'species':
                node.add_species(data)
            elif rank in ['genus', 'family', 'order', 'class', 'phylum', 'kingdom']:
                # This is the base class for this level
                node.rank = rank
                node.tax_id = data.get('tax_id')
                node.data = data
                
        # Recurse into subdirectories
        for subdir in sorted(path.iterdir()):
            if subdir.is_dir() and not subdir.name.startswith('.'):
                child = self._build_tree(subdir, node)
                node.add_child(child)
                
        # Infer rank from depth if not set
        if not node.rank and node.children:
            depth_to_rank = {0: 'kingdom', 1: 'phylum', 2: 'class', 3: 'order', 4: 'family', 5: 'genus'}
            node.rank = depth_to_rank.get(node.depth, 'unknown')
            
        return node
        
    def _generate_breadcrumbs(self, node: TaxonomyNode, depth: int = 0):
        """Recursively generate breadcrumb.md files."""
        # Check depth limit
        if self.max_depth is not None and depth > self.max_depth:
            return
            
        # Check priority filter
        if self.priority_only and node.rank == 'genus':
            parent_family = node.parent.name if node.parent else ''
            if parent_family not in PRIORITY_FAMILIES:
                return
                
        # Generate breadcrumb for this node if it has children or species
        if node.children or node.species:
            self._write_breadcrumb(node)
            
        # Recurse
        for child in node.children:
            self._generate_breadcrumbs(child, depth + 1)
            
    def _write_breadcrumb(self, node: TaxonomyNode):
        """Generate and write a breadcrumb.md file for a node."""
        breadcrumb_path = node.path / "breadcrumb.md"
        
        # Build frontmatter
        frontmatter = self._build_frontmatter(node)
        
        # Build body
        body = self._build_body(node)
        
        # Combine
        content = f"---\n{frontmatter}---\n\n{body}"
        
        if self.dry_run:
            print(f"[DRY RUN] Would write: {breadcrumb_path}")
            self.stats['would_create'] += 1
        else:
            breadcrumb_path.write_text(content, encoding='utf-8')
            print(f"Created: {breadcrumb_path}")
            self.stats['created'] += 1
            
        self.stats[f'rank_{node.rank}'] += 1
        
    def _build_frontmatter(self, node: TaxonomyNode) -> str:
        """Build YAML frontmatter for a node."""
        from datetime import date
        lines = []
        
        # Basic info (breadcrumbs-compatible order)
        title = self._format_title(node)
        lines.append(f'title: "{title}"')
        
        # Description
        desc = self._generate_description(node)
        lines.append(f'description: "{desc}"')
        
        # Category (breadcrumbs format)
        lines.append(f'category: "taxonomy/{node.rank or "unknown"}"')
        
        # Tags (flat array for breadcrumbs compatibility)
        tags = self._collect_flat_tags(node)
        if tags:
            tags_str = ', '.join(f'"{t}"' for t in tags[:8])  # Limit to 8
            lines.append(f'tags: [{tags_str}]')
        
        # Status
        lines.append('status: "Living"')
        
        # Updated date
        lines.append(f'updated: "{date.today().isoformat()}"')
        
        # Related breadcrumbs (siblings) - workspace-relative paths
        if node.parent:
            siblings = [c for c in node.parent.children if c.name != node.name][:3]
            if siblings:
                related_str = ', '.join(f'"../{sib.name}/breadcrumb.md"' for sib in siblings)
                lines.append(f'related: [{related_str}]')
            else:
                lines.append('related: []')
        else:
            lines.append('related: []')
        
        # Links_from (backlinks - parent references this node)
        if node.parent:
            lines.append('links_from: ["../breadcrumb.md"]')
        else:
            lines.append('links_from: []')
        
        # Taxonomy-specific fields
        lines.append(f'rank: "{node.rank or "unknown"}"')
        
        if node.tax_id:
            lines.append(f'taxId: {node.tax_id}')
            
        # Parent link
        if node.parent:
            lines.append('parent: "../breadcrumb.md"')
            
        # Counts
        if node.children:
            lines.append(f'children_count: {len(node.children)}')
        lines.append(f'species_count: {node.species_count}')
                    
        # Characteristics (from node data)
        chars = node.data.get('characteristics', [])
        if chars:
            lines.append('characteristics:')
            for char in chars[:5]:  # Limit to 5
                lines.append(f'  - "{char}"')
                
        # Children (for higher levels)
        if node.children and node.rank in ['kingdom', 'phylum', 'class', 'order', 'family']:
            key = 'genera' if node.rank == 'family' else 'children'
            lines.append(f'{key}:')
            for child in sorted(node.children, key=lambda c: c.name)[:10]:
                lines.append(f'  - path: "{child.name}/breadcrumb.md"')
                lines.append(f'    name: "{child.name}"')
                lines.append(f'    species_count: {child.species_count}')
                
        # Species list (for genus level)
        if node.rank == 'genus' and node.species:
            lines.append('species:')
            for sp in sorted(node.species, key=lambda s: s.get('species_name', '')):
                lines.append(f'  - file: "{sp.get("filename", "")}"')
                lines.append(f'    name: "{sp.get("species_name", "")}"')
                lines.append(f'    common_name: "{sp.get("common_name", "")}"')
                lines.append(f'    conservation: "{sp.get("conservation", "Unknown")}"')
                lines.append(f'    enriched: {str(sp.get("is_enriched", False)).lower()}')
                
        # Endangered species (for family level)
        if node.rank == 'family':
            endangered = [s for s in node.all_species 
                         if s.get('conservation', '').lower() in ['endangered', 'critically endangered']]
            if endangered:
                lines.append('endangered_species:')
                for sp in endangered[:5]:
                    lines.append(f'  - name: "{sp.get("species_name", "")}"')
                    lines.append(f'    common_name: "{sp.get("common_name", "")}"')
                    lines.append(f'    status: "{sp.get("conservation", "")}"')
                    
        return '\n'.join(lines) + '\n'
        
    def _build_body(self, node: TaxonomyNode) -> str:
        """Build markdown body content for the breadcrumb."""
        lines = []
        
        # Title
        title = self._format_title(node)
        lines.append(f'# {title}')
        lines.append('')
        
        # Description
        desc = self._generate_description(node)
        lines.append(desc)
        lines.append('')
        
        # Stats
        lines.append('## Overview')
        lines.append('')
        lines.append(f'- **Rank**: {node.rank}')
        if node.tax_id:
            lines.append(f'- **NCBI TaxId**: {node.tax_id}')
        lines.append(f'- **Total Species**: {node.species_count}')
        if node.children:
            child_type = 'Genera' if node.rank == 'family' else 'Sub-taxa'
            lines.append(f'- **{child_type}**: {len(node.children)}')
        lines.append('')
        
        # Characteristics
        chars = node.data.get('characteristics', [])
        if chars:
            lines.append('## Characteristics')
            lines.append('')
            for char in chars:
                lines.append(f'- {char}')
            lines.append('')
            
        # Children
        if node.children:
            child_type = 'Genera' if node.rank == 'family' else 'Sub-taxa'
            lines.append(f'## {child_type}')
            lines.append('')
            for child in sorted(node.children, key=lambda c: c.name):
                lines.append(f'- [{child.name}]({child.name}/breadcrumb.md) ({child.species_count} species)')
            lines.append('')
            
        # Species (for genus)
        if node.rank == 'genus' and node.species:
            lines.append('## Species')
            lines.append('')
            lines.append('| Species | Common Name | Conservation | Enriched |')
            lines.append('|---------|-------------|--------------|----------|')
            for sp in sorted(node.species, key=lambda s: s.get('species_name', '')):
                name = sp.get('species_name', 'Unknown')
                common = sp.get('common_name', '')
                cons = sp.get('conservation', 'Unknown')
                enriched = '✓' if sp.get('is_enriched') else '✗'
                lines.append(f'| {name} | {common} | {cons} | {enriched} |')
            lines.append('')
            
        # Navigation
        lines.append('## Navigation')
        lines.append('')
        if node.parent:
            lines.append(f'- [↑ Parent: {node.parent.name}](../breadcrumb.md)')
        if node.children:
            first_child = sorted(node.children, key=lambda c: c.name)[0]
            lines.append(f'- [↓ First Child: {first_child.name}]({first_child.name}/breadcrumb.md)')
        lines.append('')
        
        return '\n'.join(lines)
        
    def _format_title(self, node: TaxonomyNode) -> str:
        """Format a human-readable title for the node."""
        name = node.name
        rank = node.rank or ''
        
        # Add common descriptions for well-known taxa
        descriptions = {
            'Canidae': 'Dog Family',
            'Felidae': 'Cat Family',
            'Ursidae': 'Bear Family',
            'Mammalia': 'Mammals',
            'Chordata': 'Chordates',
            'Carnivora': 'Carnivorans',
            'Primates': 'Primates',
            'Canis': 'Wolves, Dogs, Jackals',
            'Vulpes': 'True Foxes',
            'Panthera': 'Big Cats',
            'Felis': 'Small Cats',
        }
        
        if name in descriptions:
            return f'{name} ({descriptions[name]})'
        return name
        
    def _generate_description(self, node: TaxonomyNode) -> str:
        """Generate a description for the node."""
        if node.rank == 'family':
            return f"Family of {node.species_count} species in the order {node.parent.name if node.parent else 'unknown'}."
        elif node.rank == 'genus':
            return f"Genus containing {len(node.species)} species in the family {node.parent.name if node.parent else 'unknown'}."
        elif node.rank == 'order':
            return f"Order of {node.species_count} species with {len(node.children)} families."
        else:
            return f"Taxonomic {node.rank} containing {node.species_count} species."
            
    def _collect_tags(self, node: TaxonomyNode) -> Dict[str, List[str]]:
        """Collect and categorize tags for the node."""
        tags = {
            'taxonomic': [],
            'conservation': [],
            'behavior': [],
            'habitat': [],
            'diet': [],
        }
        
        # Taxonomic tags
        tags['taxonomic'].append(node.rank or 'unknown')
        if node.name.lower() not in ['root', 'metazoa']:
            tags['taxonomic'].append(node.name.lower())
            
        # Collect from all species
        all_species = node.all_species
        
        # Conservation tags
        for sp in all_species:
            cons = sp.get('conservation', '')
            norm = CONSERVATION_STATUS_MAP.get(cons)
            if norm:
                tags['conservation'].append(norm)
                
        # Infer behavior/habitat/diet from characteristics
        all_chars = []
        for sp in all_species:
            all_chars.extend(sp.get('characteristics', []))
        all_chars.extend(node.data.get('characteristics', []))
        chars_text = ' '.join(all_chars).lower()
        
        for tag, keywords in BEHAVIOR_KEYWORDS.items():
            if any(kw in chars_text for kw in keywords):
                tags['behavior'].append(tag)
                
        for tag, keywords in HABITAT_KEYWORDS.items():
            if any(kw in chars_text for kw in keywords):
                tags['habitat'].append(tag)
                
        for tag, keywords in DIET_KEYWORDS.items():
            if any(kw in chars_text for kw in keywords):
                tags['diet'].append(tag)
                
        # Filter to unique values
        return {k: list(set(v)) for k, v in tags.items() if v}
    
    def _collect_flat_tags(self, node: TaxonomyNode) -> List[str]:
        """Collect tags as a flat list for breadcrumbs compatibility."""
        tags = []
        
        # Add taxon name and rank
        if node.name.lower() not in ['root', 'metazoa']:
            tags.append(node.name.lower())
        tags.append(node.rank or 'unknown')
        
        # Collect categorized tags and flatten
        categorized = self._collect_tags(node)
        for category, tag_list in categorized.items():
            tags.extend(tag_list)
        
        # Deduplicate while preserving order
        seen = set()
        result = []
        for tag in tags:
            if tag not in seen:
                seen.add(tag)
                result.append(tag)
        
        return result


def main():
    parser = argparse.ArgumentParser(description='Generate breadcrumb.md files for Animal Kingdom')
    parser.add_argument('--dry-run', action='store_true', help='Print without writing files')
    parser.add_argument('--max-depth', type=int, help='Maximum depth to generate')
    parser.add_argument('--priority-only', action='store_true', help='Only generate for priority families')
    parser.add_argument('--root', type=str, default='root', help='Root folder to start from')
    args = parser.parse_args()
    
    root_path = Path(args.root)
    if not root_path.exists():
        print(f"Error: Root path does not exist: {root_path}")
        return 1
        
    generator = BreadcrumbGenerator(
        root_path=root_path,
        dry_run=args.dry_run,
        max_depth=args.max_depth,
        priority_only=args.priority_only,
    )
    
    generator.generate()
    return 0


if __name__ == '__main__':
    exit(main())
