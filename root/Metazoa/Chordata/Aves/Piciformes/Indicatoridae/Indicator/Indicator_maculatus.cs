namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

/// <summary>
/// Species: Indicator maculatus
/// NCBI TaxId: 545262
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indicator_maculatus : Indicator
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indicator maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indicator_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 545262;
}
