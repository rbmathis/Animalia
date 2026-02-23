namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Papuascincus;

/// <summary>
/// Species: Papuascincus sp.
/// NCBI TaxId: 2065402
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Papuascincus_sp : Papuascincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Papuascincus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Papuascincus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2065402;
}
