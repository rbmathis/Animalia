namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Chiroderma;

/// <summary>
/// Species: Chiroderma villosum
/// NCBI TaxId: 33546
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiroderma_villosum : Chiroderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiroderma villosum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiroderma_villosum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 33546;
}
