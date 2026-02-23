namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmus;

/// <summary>
/// Species: Lemmus sp. 1 VKL-2013
/// NCBI TaxId: 1325461
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemmus_sp_1_VKL_2013 : Lemmus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemmus sp. 1 VKL-2013";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemmus_sp_1_VKL_2013";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1325461;
}
