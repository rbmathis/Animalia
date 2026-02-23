namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Mastomys;

/// <summary>
/// Species: Mastomys sp. DPL-2017
/// NCBI TaxId: 2448873
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mastomys_sp_DPL_2017 : Mastomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mastomys sp. DPL-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mastomys_sp_DPL_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2448873;
}
