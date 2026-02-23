namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus ochrogaster
/// NCBI TaxId: 79684
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_ochrogaster : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus ochrogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_ochrogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79684;
}
