namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Bison;

/// <summary>
/// Species: Bison sp. CRS-DY-42
/// NCBI TaxId: 231747
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Bison_sp_CRS_DY_42 : Bison
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Bison sp. CRS-DY-42";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Bison_sp_CRS_DY_42";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 231747;
}
