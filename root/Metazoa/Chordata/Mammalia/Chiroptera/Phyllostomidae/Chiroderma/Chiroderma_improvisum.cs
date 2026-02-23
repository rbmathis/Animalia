namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Chiroderma;

/// <summary>
/// Species: Chiroderma improvisum
/// NCBI TaxId: 33545
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiroderma_improvisum : Chiroderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiroderma improvisum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiroderma_improvisum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33545;
}
