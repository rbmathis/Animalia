namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Grammomys;

/// <summary>
/// Species: Grammomys sp. DPL-2017
/// NCBI TaxId: 2448871
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Grammomys_sp_DPL_2017 : Grammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Grammomys sp. DPL-2017";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Grammomys_sp_DPL_2017";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2448871;
}
