namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Phyllostomidae.Vampyressa;

/// <summary>
/// Species: Vampyriscus nymphaeus
/// NCBI TaxId: 3370950
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vampyriscus_nymphaeus : Vampyressa
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vampyriscus nymphaeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vampyriscus_nymphaeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3370950;
}
