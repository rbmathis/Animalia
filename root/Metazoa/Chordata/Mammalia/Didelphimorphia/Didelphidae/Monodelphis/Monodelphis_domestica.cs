namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Didelphimorphia.Didelphidae.Monodelphis;

/// <summary>
/// Species: Monodelphis domestica
/// NCBI TaxId: 13616
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Monodelphis_domestica : Monodelphis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Monodelphis domestica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Monodelphis_domestica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13616;
}
