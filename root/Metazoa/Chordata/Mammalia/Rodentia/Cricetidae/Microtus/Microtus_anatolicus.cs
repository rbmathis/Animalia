namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus anatolicus
/// NCBI TaxId: 670077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_anatolicus : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus anatolicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_anatolicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 670077;
}
