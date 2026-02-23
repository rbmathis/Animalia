namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus;

/// <summary>
/// Species: Lemmus trimucronatus
/// NCBI TaxId: 84770
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemmus_trimucronatus : Lemmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemmus trimucronatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemmus_trimucronatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 84770;
}
