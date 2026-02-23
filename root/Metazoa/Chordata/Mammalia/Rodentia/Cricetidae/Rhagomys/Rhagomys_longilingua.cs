namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Rhagomys;

/// <summary>
/// Species: Rhagomys longilingua
/// NCBI TaxId: 329889
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhagomys_longilingua : Rhagomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhagomys longilingua";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhagomys_longilingua";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329889;
}
