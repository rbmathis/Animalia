namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Aethomys;

/// <summary>
/// Species: Aethomys sp. DPL-2017
/// NCBI TaxId: 2448864
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Aethomys_sp_DPL_2017 : Aethomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Aethomys sp. DPL-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Aethomys_sp_DPL_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2448864;
}
