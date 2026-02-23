namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus;

/// <summary>
/// Species: Lemmus amurensis
/// NCBI TaxId: 592740
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemmus_amurensis : Lemmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemmus amurensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemmus_amurensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 592740;
}
