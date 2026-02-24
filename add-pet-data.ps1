<#
.SYNOPSIS
    Adds pet species metadata to breadcrumb files in the Animal Kingdom repository.

.DESCRIPTION
    This script:
    1. Marks known pet species in genus breadcrumbs with `pet: true`
    2. Adds `pet_species` array to genus breadcrumbs
    3. Adds `pet_genera` array to family breadcrumbs
    4. Adds `pet_families` array to order breadcrumbs
    5. Adds `has-pets` tag at all levels

.PARAMETER DryRun
    Show what would be changed without modifying files.

.EXAMPLE
    .\add-pet-data.ps1
    # Apply pet data to all breadcrumbs

.EXAMPLE
    .\add-pet-data.ps1 -DryRun
    # Preview changes without modifying files
#>

param(
    [switch]$DryRun
)

$ErrorActionPreference = "Stop"

# Known pet species with their paths
$PetSpecies = @(
    @{
        File       = "Felis_catus.cs"
        Name       = "Felis catus"
        CommonName = "Domestic Cat"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Carnivora/Felidae/Felis"
        Family     = "Felidae"
        Order      = "Carnivora"
    },
    @{
        File       = "Canis_lupus.cs"  # Domestic dogs are subspecies of Canis lupus
        Name       = "Canis lupus"
        CommonName = "Dog (domesticated wolf)"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Carnivora/Canidae/Canis"
        Family     = "Canidae"
        Order      = "Carnivora"
    },
    @{
        File       = "Carassius_auratus.cs"
        Name       = "Carassius auratus"
        CommonName = "Goldfish"
        GenusPath  = "root/Metazoa/Chordata/Actinopteri/Cypriniformes/Cyprinidae/Carassius"
        Family     = "Cyprinidae"
        Order      = "Cypriniformes"
    },
    @{
        File       = "Cavia_porcellus.cs"
        Name       = "Cavia porcellus"
        CommonName = "Guinea Pig"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Rodentia/Caviidae/Cavia"
        Family     = "Caviidae"
        Order      = "Rodentia"
    },
    @{
        File       = "Oryctolagus_cuniculus.cs"
        Name       = "Oryctolagus cuniculus"
        CommonName = "European Rabbit"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Lagomorpha/Leporidae/Oryctolagus"
        Family     = "Leporidae"
        Order      = "Lagomorpha"
    },
    @{
        File       = "Mesocricetus_auratus.cs"
        Name       = "Mesocricetus auratus"
        CommonName = "Golden Hamster"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Rodentia/Cricetidae/Mesocricetus"
        Family     = "Cricetidae"
        Order      = "Rodentia"
    },
    @{
        File       = "Melopsittacus_undulatus.cs"
        Name       = "Melopsittacus undulatus"
        CommonName = "Budgerigar"
        GenusPath  = "root/Metazoa/Chordata/Aves/Psittaciformes/Psittaculidae/Melopsittacus"
        Family     = "Psittaculidae"
        Order      = "Psittaciformes"
    },
    @{
        File       = "Mustela_putorius.cs"
        Name       = "Mustela putorius"
        CommonName = "Ferret (European Polecat)"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Carnivora/Mustelidae/Mustela"
        Family     = "Mustelidae"
        Order      = "Carnivora"
    },
    @{
        File       = "Chinchilla_lanigera.cs"
        Name       = "Chinchilla lanigera"
        CommonName = "Long-tailed Chinchilla"
        GenusPath  = "root/Metazoa/Chordata/Mammalia/Rodentia/Chinchillidae/Chinchilla"
        Family     = "Chinchillidae"
        Order      = "Rodentia"
    }
)

Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "  Pet Data Seeding Script" -ForegroundColor Cyan
Write-Host "========================================`n" -ForegroundColor Cyan

if ($DryRun) {
    Write-Host "[DRY RUN] No files will be modified`n" -ForegroundColor Yellow
}

# Group by genus for genus-level updates
$byGenus = $PetSpecies | Group-Object -Property GenusPath

# Group by family for family-level updates
$byFamily = $PetSpecies | Group-Object -Property { "$($_.GenusPath | Split-Path -Parent)" }

# Group by order for order-level updates
$byOrder = $PetSpecies | Group-Object -Property Order

function Add-HasPetsTag {
    param([string]$Content)

    # Check if has-pets tag already exists
    if ($Content -match '"has-pets"') {
        return $Content
    }

    # Add has-pets to tags array
    if ($Content -match 'tags:\s*\[([^\]]*)\]') {
        $existingTags = $Matches[1]
        $newTags = "$existingTags, `"has-pets`""
        return $Content -replace "tags:\s*\[[^\]]*\]", "tags: [$newTags]"
    }

    return $Content
}

function Add-PetSpeciesToGenus {
    param(
        [string]$BreadcrumbPath,
        [array]$Pets
    )

    if (-not (Test-Path $BreadcrumbPath)) {
        Write-Host "  NOT FOUND: $BreadcrumbPath" -ForegroundColor Red
        return
    }

    $content = Get-Content $BreadcrumbPath -Raw
    $modified = $false

    # Add has-pets tag
    $newContent = Add-HasPetsTag -Content $content
    if ($newContent -ne $content) {
        $modified = $true
        $content = $newContent
    }

    # Check if pet_species section already exists
    if ($content -notmatch "pet_species:") {
        # Build pet_species YAML
        $petYaml = "pet_species:`n"
        foreach ($pet in $Pets) {
            $petYaml += "  - file: `"$($pet.File)`"`n"
            $petYaml += "    name: `"$($pet.Name)`"`n"
            $petYaml += "    common_name: `"$($pet.CommonName)`"`n"
        }

        # Insert before the closing --- of frontmatter, or after species section
        if ($content -match "(species:\s*\n(?:[\s\S]*?))(\n---|\ncharacteristics:)") {
            # Find end of species section and insert after
            $content = $content -replace "(endangered_species:\s*\[[^\]]*\])", "`$1`n$petYaml"
            $modified = $true
        }
        elseif ($content -match "(species_count:\s*\d+)") {
            $content = $content -replace "(species_count:\s*\d+)", "`$1`n$petYaml"
            $modified = $true
        }
    }

    # Also add pet: true to species entries
    foreach ($pet in $Pets) {
        $fileName = $pet.File
        # Find the species entry and add pet: true if not present
        $pattern = "(-\s*file:\s*`"$fileName`"[\s\S]*?enriched:\s*\w+)"
        if ($content -match $pattern -and $content -notmatch "$fileName[\s\S]*?pet:\s*true") {
            $content = $content -replace $pattern, "`$1`n    pet: true"
            $modified = $true
        }
    }

    if ($modified) {
        if ($DryRun) {
            Write-Host "  WOULD UPDATE: $BreadcrumbPath" -ForegroundColor Yellow
        }
        else {
            Set-Content -Path $BreadcrumbPath -Value $content -NoNewline
            Write-Host "  UPDATED: $BreadcrumbPath" -ForegroundColor Green
        }
    }
    else {
        Write-Host "  UNCHANGED: $BreadcrumbPath" -ForegroundColor Gray
    }
}

function Add-PetGeneraToFamily {
    param(
        [string]$BreadcrumbPath,
        [array]$Genera
    )

    if (-not (Test-Path $BreadcrumbPath)) {
        Write-Host "  NOT FOUND: $BreadcrumbPath" -ForegroundColor Red
        return
    }

    $content = Get-Content $BreadcrumbPath -Raw
    $modified = $false

    # Add has-pets tag
    $newContent = Add-HasPetsTag -Content $content
    if ($newContent -ne $content) {
        $modified = $true
        $content = $newContent
    }

    # Check if pet_genera section already exists
    if ($content -notmatch "pet_genera:") {
        # Build pet_genera YAML
        $petYaml = "pet_genera:`n"
        $uniqueGenera = $Genera | Select-Object -Unique
        foreach ($genus in $uniqueGenera) {
            $genusName = Split-Path $genus -Leaf
            $petYaml += "  - name: `"$genusName`"`n"
            $petYaml += "    path: `"$genusName/breadcrumb.md`"`n"
        }

        # Insert after genera section or after children_count
        if ($content -match "(genera:\s*\n(?:[\s\S]*?))(\n[a-z_]+:|\n---)") {
            $content = $content -replace "(genera:\s*\n(?:[\s\S]*?))(\n[a-z_]+:|\n---)", "`$1$petYaml`$2"
            $modified = $true
        }
        elseif ($content -match "(children_count:\s*\d+)") {
            $content = $content -replace "(children_count:\s*\d+)", "`$1`n$petYaml"
            $modified = $true
        }
    }

    if ($modified) {
        if ($DryRun) {
            Write-Host "  WOULD UPDATE: $BreadcrumbPath" -ForegroundColor Yellow
        }
        else {
            Set-Content -Path $BreadcrumbPath -Value $content -NoNewline
            Write-Host "  UPDATED: $BreadcrumbPath" -ForegroundColor Green
        }
    }
    else {
        Write-Host "  UNCHANGED: $BreadcrumbPath" -ForegroundColor Gray
    }
}

# Process genus breadcrumbs
Write-Host "Step 1: Updating genus breadcrumbs..." -ForegroundColor Cyan
foreach ($group in $byGenus) {
    $genusPath = $group.Name
    $breadcrumb = Join-Path $genusPath "breadcrumb.md"
    Add-PetSpeciesToGenus -BreadcrumbPath $breadcrumb -Pets $group.Group
}

# Process family breadcrumbs
Write-Host "`nStep 2: Updating family breadcrumbs..." -ForegroundColor Cyan
$familyPaths = $PetSpecies | ForEach-Object { Split-Path $_.GenusPath -Parent } | Select-Object -Unique
foreach ($familyPath in $familyPaths) {
    $breadcrumb = Join-Path $familyPath "breadcrumb.md"
    $genera = $PetSpecies | Where-Object { (Split-Path $_.GenusPath -Parent) -eq $familyPath } | ForEach-Object { $_.GenusPath }
    Add-PetGeneraToFamily -BreadcrumbPath $breadcrumb -Genera $genera
}

# Summary
Write-Host "`n========================================" -ForegroundColor Cyan
Write-Host "  Summary" -ForegroundColor Cyan
Write-Host "========================================" -ForegroundColor Cyan
Write-Host "  Pet species identified: $($PetSpecies.Count)"
Write-Host "  Genera with pets: $($byGenus.Count)"
Write-Host "  Families with pets: $($familyPaths.Count)"
Write-Host "========================================`n" -ForegroundColor Cyan

if ($DryRun) {
    Write-Host "Run without -DryRun to apply changes." -ForegroundColor Yellow
}
