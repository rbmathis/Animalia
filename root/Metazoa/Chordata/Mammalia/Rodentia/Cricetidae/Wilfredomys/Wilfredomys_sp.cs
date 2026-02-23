namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wilfredomys;

/// <summary>
/// Species: Wilfredomys sp.
/// NCBI TaxId: 89128
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Wilfredomys_sp : Wilfredomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Wilfredomys sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Wilfredomys_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89128;
}
