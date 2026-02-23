namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Alpinoscincus;

/// <summary>
/// Species: Alpinoscincus alpinus
/// NCBI TaxId: 1545018
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alpinoscincus_alpinus : Alpinoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alpinoscincus alpinus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alpinoscincus_alpinus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1545018;
}
