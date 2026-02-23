namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Varanidae.Varanus;

/// <summary>
/// Species: Varanus griseus
/// NCBI TaxId: 52184
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Varanus_griseus : Varanus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Varanus griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Varanus_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 52184;
}
