namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Chiroderma;

/// <summary>
/// Species: Chiroderma trinitatum
/// NCBI TaxId: 27647
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiroderma_trinitatum : Chiroderma
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiroderma trinitatum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiroderma_trinitatum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 27647;
}
