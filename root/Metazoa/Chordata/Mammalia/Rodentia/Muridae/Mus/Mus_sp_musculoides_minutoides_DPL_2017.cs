namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mus;

/// <summary>
/// Species: Mus sp. musculoides-minutoides DPL-2017
/// NCBI TaxId: 2448885
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mus_sp_musculoides_minutoides_DPL_2017 : Mus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mus sp. musculoides-minutoides DPL-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mus_sp_musculoides_minutoides_DPL_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2448885;
}
