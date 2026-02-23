namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus sp. pellewensis
/// NCBI TaxId: 386768
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_sp_pellewensis : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus sp. pellewensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_sp_pellewensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 386768;
}
