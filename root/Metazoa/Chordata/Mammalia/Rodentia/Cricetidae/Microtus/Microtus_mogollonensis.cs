namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus mogollonensis
/// NCBI TaxId: 2876074
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_mogollonensis : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus mogollonensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_mogollonensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2876074;
}
