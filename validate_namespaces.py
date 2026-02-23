#!/usr/bin/env python3
"""
Validate C# namespace declarations against expected directory-based namespaces.
"""

import os
import re
from pathlib import Path
from typing import Tuple, Optional

def extract_namespace(file_path: str) -> Optional[str]:
    """
    Extract namespace declaration from a C# file.
    Looks in the first 50 lines for a namespace declaration.
    """
    try:
        with open(file_path, 'r', encoding='utf-8', errors='ignore') as f:
            for i, line in enumerate(f):
                if i >= 50:
                    break
                # Look for namespace declaration
                match = re.search(r'namespace\s+([\w.]+)', line)
                if match:
                    return match.group(1)
    except Exception as e:
        print(f"Error reading file {file_path}: {e}")
    
    return None

def compute_expected_namespace(file_path: str) -> str:
    """
    Compute the expected namespace based on directory structure.
    Format: AnimalKingdom.{folder_path_with_dots}
    Example: root/Metazoa/Chordata/Mammalia/Canidae/Canis/Canis_lupus.cs
    Should be: AnimalKingdom.root.Metazoa.Chordata.Mammalia.Canidae.Canis
    """
    # Get the relative path from root directory
    path_obj = Path(file_path)
    
    # Get all parent directories from the file up to "root"
    parts = []
    current = path_obj.parent
    
    # Walk backwards to build the path
    while current.name != '':
        parts.insert(0, current.name)
        current = current.parent
        # Stop if we've gone too far
        if current.name == '':
            break
    
    # Find the index where "root" starts
    if 'root' in parts:
        root_idx = parts.index('root')
        namespace_parts = parts[root_idx:]
    else:
        # Fallback if "root" not found
        namespace_parts = parts
    
    expected = "AnimalKingdom." + ".".join(namespace_parts)
    return expected

def validate_namespaces(root_dir: str = "root") -> None:
    """
    Main function to validate all C# files in the root directory.
    """
    
    # Convert to absolute path
    root_path = Path(root_dir)
    if not root_path.is_absolute():
        root_path = Path.cwd() / root_path
    
    if not root_path.exists():
        print(f"Error: Directory '{root_path}' does not exist.")
        return
    
    print(f"Starting namespace validation in: {root_path}")
    print("=" * 80)
    
    # Statistics
    total_files = 0
    valid_namespaces = 0
    invalid_namespaces = 0
    no_namespace = 0
    mismatches = []
    
    # Find all .cs files recursively
    cs_files = list(root_path.rglob("*.cs"))
    total_files = len(cs_files)
    
    print(f"Found {total_files} .cs files to scan")
    print("=" * 80)
    
    for i, file_path in enumerate(cs_files, 1):
        # Progress update every 1000 files
        if i % 1000 == 0:
            print(f"Progress: {i}/{total_files} files scanned...")
        
        # Extract actual namespace
        actual_namespace = extract_namespace(str(file_path))
        
        # Compute expected namespace
        expected_namespace = compute_expected_namespace(str(file_path))
        
        # Compare
        if actual_namespace is None:
            no_namespace += 1
            # Only report if the file is not at root level
            if file_path.parent != root_path:
                mismatches.append({
                    'file': str(file_path.relative_to(root_path.parent)),
                    'expected': expected_namespace,
                    'actual': 'NO NAMESPACE FOUND',
                    'status': 'MISSING'
                })
        elif actual_namespace == expected_namespace:
            valid_namespaces += 1
        else:
            invalid_namespaces += 1
            mismatches.append({
                'file': str(file_path.relative_to(root_path.parent)),
                'expected': expected_namespace,
                'actual': actual_namespace,
                'status': 'MISMATCH'
            })
    
    print("=" * 80)
    print("\nVALIDATION RESULTS")
    print("=" * 80)
    
    if mismatches:
        print(f"\nFound {len(mismatches)} namespace issues:\n")
        for item in mismatches:
            print(f"File: {item['file']}")
            print(f"  Status: {item['status']}")
            print(f"  Expected: {item['expected']}")
            print(f"  Actual: {item['actual']}")
            print()
    else:
        print("\n✓ All namespace declarations are correct!")
        print()
    
    print("=" * 80)
    print("SUMMARY")
    print("=" * 80)
    print(f"Total files scanned:     {total_files}")
    print(f"Valid namespaces:        {valid_namespaces}")
    print(f"Invalid namespaces:      {invalid_namespaces}")
    print(f"Files with no namespace: {no_namespace}")
    print("=" * 80)

if __name__ == "__main__":
    validate_namespaces()