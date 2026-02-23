namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Madascincus;

/// <summary>
/// Species: Madascincus sp. baeus
/// NCBI TaxId: 1926517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Madascincus_sp_baeus : Madascincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Madascincus sp. baeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Madascincus_sp_baeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1926517;
}
