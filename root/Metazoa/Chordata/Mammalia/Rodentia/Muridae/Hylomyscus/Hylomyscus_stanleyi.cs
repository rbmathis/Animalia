namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hylomyscus;

/// <summary>
/// Species: Hylomyscus stanleyi
/// NCBI TaxId: 2735144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylomyscus_stanleyi : Hylomyscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylomyscus stanleyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylomyscus_stanleyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2735144;
}
