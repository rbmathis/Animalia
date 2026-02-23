namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pseudomys;

/// <summary>
/// Species: Pseudomys fumeus
/// NCBI TaxId: 442609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pseudomys_fumeus : Pseudomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pseudomys fumeus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pseudomys_fumeus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 442609;
}
