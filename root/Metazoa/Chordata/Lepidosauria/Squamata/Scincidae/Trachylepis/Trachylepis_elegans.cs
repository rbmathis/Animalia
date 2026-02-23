namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Trachylepis;

/// <summary>
/// Species: Trachylepis elegans
/// NCBI TaxId: 96428
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trachylepis_elegans : Trachylepis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trachylepis elegans";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trachylepis_elegans";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 96428;
}
