namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus kordensis
/// NCBI TaxId: 437654
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_kordensis : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus kordensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_kordensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 437654;
}
