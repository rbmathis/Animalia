namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Ctenomyidae.Ctenomys;

/// <summary>
/// Species: Ctenomys leucodon
/// NCBI TaxId: 61871
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ctenomys_leucodon : Ctenomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ctenomys leucodon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ctenomys_leucodon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 61871;
}
