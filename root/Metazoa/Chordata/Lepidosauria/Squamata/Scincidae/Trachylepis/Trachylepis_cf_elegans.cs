namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis;

/// <summary>
/// Species: Trachylepis cf. elegans
/// NCBI TaxId: 1273126
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachylepis_cf_elegans : Trachylepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachylepis cf. elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachylepis_cf_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1273126;
}
