namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Didelphis;

/// <summary>
/// Species: Didelphis marsupialis
/// NCBI TaxId: 9268
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Didelphis_marsupialis : Didelphis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Didelphis marsupialis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Didelphis_marsupialis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9268;
}
