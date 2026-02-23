namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

/// <summary>
/// Species: Indicator exilis
/// NCBI TaxId: 381870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indicator_exilis : Indicator
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indicator exilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indicator_exilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 381870;
}
