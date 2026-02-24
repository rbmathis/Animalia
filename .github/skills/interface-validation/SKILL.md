---
name: interface-validation
description: Validate that C# classes implement required interfaces across the codebase. Use when checking interface compliance, finding missing implementations, or verifying inheritance contracts. Triggered for "validate interfaces", "check implementation", "verify contracts", "find interface violations".
metadata:
  author: animal-kingdom
  version: "1.0"
---

# Interface Validation via Build + Reflection

Validate interface compliance across 160K files **without reading source files**. Use compiled DLLs and .NET reflection instead.

## When to Use

- Verifying species classes implement genus interfaces (e.g., ICanis, IVulpes)
- Finding missing interface implementations across a family
- Checking that all types in a namespace implement expected interfaces
- Validating inheritance contracts at scale

## Why This Approach

| Approach | Files Read | Time | Reliability |
|----------|-----------|------|-------------|
| Read source files | 160K | Hours | Error-prone (regex parsing) |
| Build + Reflection | 0 | Seconds | 100% accurate (compiler-verified) |

The C# compiler **already validates** interface compliance. If it builds, it's valid.

## Strategy: Build → Load DLL → Reflect

### Step 1: Build the Project

Each genus/family folder has its own `.csproj`:

```powershell
# Build a specific genus
dotnet build root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis/Canis.csproj

# Build an entire family
dotnet build root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canidae.csproj

# Build everything (slow but comprehensive)
dotnet build root/root.csproj
```

### Step 2: Find the Output DLL

```powershell
# Find the built DLL
$dll = Get-ChildItem -Path "root/**/Canis/bin" -Recurse -Filter "*.dll" | 
    Where-Object { $_.Name -notmatch "System|Microsoft" } |
    Select-Object -First 1
```

### Step 3: Use Reflection to Check Types

```powershell
# Load the assembly
$asm = [System.Reflection.Assembly]::LoadFrom($dll.FullName)

# Find all species types (contain underscore)
$speciesTypes = $asm.GetTypes() | Where-Object { $_.Name -match "_" -and -not $_.IsInterface }

# Get the genus interface
$interface = $asm.GetTypes() | Where-Object { $_.Name -eq "ICanis" } | Select-Object -First 1

# Check each species
$results = $speciesTypes | ForEach-Object {
    [PSCustomObject]@{
        Species = $_.Name
        ImplementsInterface = $interface.IsAssignableFrom($_)
        Interfaces = ($_.GetInterfaces() | Select-Object -ExpandProperty Name) -join ", "
    }
}

# Show results
$results | Format-Table -AutoSize

# Find violations
$violations = $results | Where-Object { -not $_.ImplementsInterface }
if ($violations) {
    Write-Warning "Found $($violations.Count) types not implementing $($interface.Name)"
    $violations | Format-Table
}
```

### Step 4: Check Across Multiple Genera/Families

```powershell
# Build the family
dotnet build root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canidae.csproj

# Find all DLLs in the family
$dlls = Get-ChildItem -Path "root/**/Canidae/**/bin" -Recurse -Filter "*.dll" |
    Where-Object { $_.Name -notmatch "System|Microsoft" }

# Check each genus
foreach ($dll in $dlls) {
    $asm = [System.Reflection.Assembly]::LoadFrom($dll.FullName)
    $genusName = [System.IO.Path]::GetFileNameWithoutExtension($dll.Name)
    $interface = $asm.GetTypes() | Where-Object { $_.Name -eq "I$genusName" } | Select-Object -First 1
    
    if ($interface) {
        $speciesTypes = $asm.GetTypes() | Where-Object { $_.Name -match "_" }
        $violations = $speciesTypes | Where-Object { -not $interface.IsAssignableFrom($_) }
        
        if ($violations) {
            Write-Warning "$genusName has $($violations.Count) violations"
        } else {
            Write-Host "$genusName`: All $($speciesTypes.Count) species implement I$genusName" -ForegroundColor Green
        }
    }
}
```

## Compile Errors = Interface Violations

If `dotnet build` fails with errors like:
```
error CS0535: 'Canis_lupus' does not implement interface member 'ICanis.SomeProperty'
```

That **IS** the answer. Parse the build output:

```powershell
$buildOutput = dotnet build root/root.csproj 2>&1
$interfaceErrors = $buildOutput | Select-String "does not implement interface member"
$interfaceErrors | ForEach-Object { $_.Line }
```

## Example Output

```
Canis: All 28 species implement ICanis ✓
Vulpes: All 12 species implement IVulpes ✓
Lycaon: All 2 species implement ILycaon ✓
```

## Anti-Patterns (Don't Do This)

- ❌ Reading 160K .cs files to check for interface declarations
- ❌ Grepping for `: ICanis` (misses inherited implementations)
- ❌ Using semantic search to find interface usages
- ❌ Manually checking each species file

## Related

- For finding compilation errors: `dotnet build 2>&1 | Select-String "error CS"`
- For finding interface implementations: `grep -r ": IPackAnimal" root/**/*.cs`
