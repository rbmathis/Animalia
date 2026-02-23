#!/usr/bin/env python3
"""
Generate breadcrumbs for ALL taxonomic levels where they add value:
- Kingdom, Phylum, Class levels (top navigation)
- All Orders (family listings)
- All Families (genus listings, endangered species)
- All Genera (species listings with conservation status)

This is where breadcrumbs make the biggest difference for navigation.
"""

import sys
from pathlib import Path

# Import the generate_breadcrumb function
sys.path.insert(0, '.')
from generate_breadcrumbs_targeted import generate_breadcrumb

def find_all_taxonomy_dirs(root: Path):
    """Find all directories that should have breadcrumbs."""
    dirs = []
    
    # Top levels - always include
    top_levels = [
        root,
        root / "Metazoa",
        root / "Metazoa" / "Chordata",
        root / "Metazoa" / "Chordata" / "Mammalia",
    ]
    for p in top_levels:
        if p.exists():
            dirs.append(p)
    
    # Find all orders (direct children of Mammalia)
    mammalia = root / "Metazoa" / "Chordata" / "Mammalia"
    if mammalia.exists():
        for order_dir in sorted(mammalia.iterdir()):
            if order_dir.is_dir() and not order_dir.name.startswith('.'):
                dirs.append(order_dir)
                
                # Find all families (direct children of orders)
                for family_dir in sorted(order_dir.iterdir()):
                    if family_dir.is_dir() and not family_dir.name.startswith('.'):
                        dirs.append(family_dir)
                        
                        # Find all genera (direct children of families)
                        for genus_dir in sorted(family_dir.iterdir()):
                            if genus_dir.is_dir() and not genus_dir.name.startswith('.'):
                                dirs.append(genus_dir)
    
    return dirs


def main():
    root = Path("root")
    
    print("Finding all taxonomy directories...")
    dirs = find_all_taxonomy_dirs(root)
    print(f"Found {len(dirs)} directories to process\n")
    
    # Count by type
    orders = [d for d in dirs if len(d.relative_to(root).parts) == 4]
    families = [d for d in dirs if len(d.relative_to(root).parts) == 5]
    genera = [d for d in dirs if len(d.relative_to(root).parts) == 6]
    
    print(f"  Top levels: 4")
    print(f"  Orders: {len(orders)}")
    print(f"  Families: {len(families)}")
    print(f"  Genera: {len(genera)}")
    print()
    
    # Generate breadcrumbs
    created = 0
    for i, path in enumerate(dirs):
        if (i + 1) % 100 == 0:
            print(f"Progress: {i + 1}/{len(dirs)}...")
        generate_breadcrumb(path)
        created += 1
    
    print(f"\nDone! Generated {created} breadcrumbs.")


if __name__ == '__main__':
    main()
