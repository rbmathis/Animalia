namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus nebulosus
/// NCBI TaxId: 735376
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_nebulosus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus nebulosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_nebulosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 735376;
}
