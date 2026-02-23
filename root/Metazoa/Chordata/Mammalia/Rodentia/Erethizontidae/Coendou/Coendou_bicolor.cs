namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

/// <summary>
/// Species: Coendou bicolor
/// NCBI TaxId: 43320
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coendou_bicolor : Coendou
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coendou bicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coendou_bicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43320;
}
