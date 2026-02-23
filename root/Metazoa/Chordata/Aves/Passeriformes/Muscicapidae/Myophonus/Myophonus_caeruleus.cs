namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Myophonus;

/// <summary>
/// Species: Myophonus caeruleus
/// NCBI TaxId: 869933
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myophonus_caeruleus : Myophonus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myophonus caeruleus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myophonus_caeruleus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 869933;
}
