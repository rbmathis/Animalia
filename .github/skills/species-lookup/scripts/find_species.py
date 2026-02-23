#!/usr/bin/env python3
"""
Species Lookup Script for Animal Kingdom Repository

Find species files by scientific name, common name, or NCBI TaxId.

Usage:
    python find_species.py --name "Canis lupus"
    python find_species.py --common "Grey Wolf"
    python find_species.py --taxid 9612
    python find_species.py --genus Canis
"""

import argparse
import re
from pathlib import Path


def find_by_scientific_name(name: str, root: Path) -> list[Path]:
    """Find species by scientific name (e.g., 'Canis lupus')."""
    # Convert to filename pattern: "Canis lupus" -> "Canis_lupus.cs"
    filename = name.replace(" ", "_") + ".cs"
    pattern = f"**/{filename}"
    return list(root.glob(pattern))


def find_by_taxid(taxid: int, root: Path) -> list[Path]:
    """Find species by NCBI TaxId."""
    results = []
    pattern = re.compile(rf'TaxId\s*=>\s*{taxid}\b')
    
    # Search in likely locations first
    for cs_file in root.rglob("*.cs"):
        try:
            content = cs_file.read_text(encoding='utf-8')
            if pattern.search(content):
                results.append(cs_file)
        except Exception:
            continue
    
    return results


def find_by_common_name(name: str, root: Path) -> list[Path]:
    """Find species by common name (e.g., 'Grey Wolf')."""
    results = []
    pattern = re.compile(rf'CommonName\s*=>\s*"[^"]*{re.escape(name)}[^"]*"', re.IGNORECASE)
    
    for cs_file in root.rglob("*.cs"):
        try:
            content = cs_file.read_text(encoding='utf-8')
            if pattern.search(content):
                results.append(cs_file)
        except Exception:
            continue
    
    return results


def list_genus_species(genus: str, root: Path) -> list[dict]:
    """List all species in a genus by reading the breadcrumb."""
    import yaml
    
    # Find genus breadcrumb
    pattern = f"**/{genus}/breadcrumb.md"
    breadcrumbs = list(root.glob(pattern))
    
    if not breadcrumbs:
        return []
    
    breadcrumb = breadcrumbs[0]
    content = breadcrumb.read_text(encoding='utf-8')
    
    # Extract YAML frontmatter
    if content.startswith('---'):
        end = content.find('---', 3)
        if end > 0:
            yaml_content = content[3:end]
            try:
                data = yaml.safe_load(yaml_content)
                return data.get('species', [])
            except Exception:
                pass
    
    return []


def extract_species_info(filepath: Path) -> dict:
    """Extract key information from a species file."""
    content = filepath.read_text(encoding='utf-8')
    
    info = {'file': str(filepath)}
    
    patterns = {
        'species_name': r'SpeciesName\s*=>\s*"([^"]+)"',
        'common_name': r'CommonName\s*=>\s*"([^"]*)"',
        'tax_id': r'TaxId\s*=>\s*(\d+)',
        'conservation': r'ConservationStatus\s*=>\s*"([^"]+)"',
        'is_enriched': r'IsEnriched\s*=\s*(true|false)',
        'lifespan': r'AverageLifespanYears\s*=>\s*([\d.]+)',
    }
    
    for key, pattern in patterns.items():
        match = re.search(pattern, content)
        if match:
            value = match.group(1)
            if key == 'is_enriched':
                value = value.lower() == 'true'
            elif key == 'tax_id':
                value = int(value)
            elif key == 'lifespan':
                value = float(value)
            info[key] = value
    
    return info


def main():
    parser = argparse.ArgumentParser(description='Find species in Animal Kingdom repository')
    parser.add_argument('--name', help='Scientific name (e.g., "Canis lupus")')
    parser.add_argument('--common', help='Common name (e.g., "Grey Wolf")')
    parser.add_argument('--taxid', type=int, help='NCBI TaxId (e.g., 9612)')
    parser.add_argument('--genus', help='List all species in a genus')
    parser.add_argument('--root', default='root', help='Root folder (default: root)')
    args = parser.parse_args()
    
    root = Path(args.root)
    
    if args.name:
        results = find_by_scientific_name(args.name, root)
        if results:
            for r in results:
                info = extract_species_info(r)
                print(f"\n{info.get('species_name', 'Unknown')}")
                print(f"  File: {r}")
                print(f"  Common name: {info.get('common_name', 'Unknown')}")
                print(f"  TaxId: {info.get('tax_id', 'Unknown')}")
                print(f"  Conservation: {info.get('conservation', 'Unknown')}")
                print(f"  Enriched: {info.get('is_enriched', False)}")
        else:
            print(f"No species found matching '{args.name}'")
    
    elif args.taxid:
        results = find_by_taxid(args.taxid, root)
        if results:
            for r in results:
                info = extract_species_info(r)
                print(f"\n{info.get('species_name', 'Unknown')} (TaxId: {args.taxid})")
                print(f"  File: {r}")
                print(f"  Common name: {info.get('common_name', 'Unknown')}")
                print(f"  Conservation: {info.get('conservation', 'Unknown')}")
        else:
            print(f"No species found with TaxId {args.taxid}")
    
    elif args.common:
        results = find_by_common_name(args.common, root)
        if results:
            for r in results:
                info = extract_species_info(r)
                print(f"\n{info.get('species_name', 'Unknown')}")
                print(f"  File: {r}")
                print(f"  Common name: {info.get('common_name', 'Unknown')}")
                print(f"  Conservation: {info.get('conservation', 'Unknown')}")
        else:
            print(f"No species found with common name containing '{args.common}'")
    
    elif args.genus:
        species_list = list_genus_species(args.genus, root)
        if species_list:
            print(f"\nSpecies in genus {args.genus}:\n")
            for sp in species_list:
                name = sp.get('name', 'Unknown')
                common = sp.get('common_name', '')
                cons = sp.get('conservation', 'Unknown')
                enriched = '✓' if sp.get('enriched') else '✗'
                print(f"  {name} ({common}) - {cons} [{enriched}]")
        else:
            print(f"No species found in genus '{args.genus}' (or breadcrumb not found)")
    
    else:
        parser.print_help()


if __name__ == '__main__':
    main()
