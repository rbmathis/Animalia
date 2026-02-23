namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus giganteus
/// NCBI TaxId: 62041
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_giganteus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus giganteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_giganteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 62041;
}
