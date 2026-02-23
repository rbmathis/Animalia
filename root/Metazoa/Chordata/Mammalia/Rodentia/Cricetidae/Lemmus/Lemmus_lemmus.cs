namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus;

/// <summary>
/// Species: Lemmus lemmus
/// NCBI TaxId: 79949
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemmus_lemmus : Lemmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemmus lemmus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemmus_lemmus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 79949;
}
