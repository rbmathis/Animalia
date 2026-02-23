namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

/// <summary>
/// Species: Indicator archipelagicus
/// NCBI TaxId: 2478889
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indicator_archipelagicus : Indicator
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indicator archipelagicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indicator_archipelagicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2478889;
}
