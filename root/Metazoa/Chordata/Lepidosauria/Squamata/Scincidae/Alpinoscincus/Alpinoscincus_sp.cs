namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Alpinoscincus;

/// <summary>
/// Species: Alpinoscincus sp.
/// NCBI TaxId: 2878438
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Alpinoscincus_sp : Alpinoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Alpinoscincus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Alpinoscincus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2878438;
}
