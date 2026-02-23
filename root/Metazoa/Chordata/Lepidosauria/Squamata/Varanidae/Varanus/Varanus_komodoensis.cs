namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus komodoensis
/// NCBI TaxId: 61221
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_komodoensis : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus komodoensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_komodoensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61221;
}
