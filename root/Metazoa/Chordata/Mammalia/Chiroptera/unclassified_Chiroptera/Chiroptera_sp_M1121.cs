namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.unclassified_Chiroptera;

/// <summary>
/// Species: Chiroptera sp. M1121
/// NCBI TaxId: 2792203
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiroptera_sp_M1121 : unclassified_Chiroptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiroptera sp. M1121";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiroptera_sp_M1121";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2792203;
}
