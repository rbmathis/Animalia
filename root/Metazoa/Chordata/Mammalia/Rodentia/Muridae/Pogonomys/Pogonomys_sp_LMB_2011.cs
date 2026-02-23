namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Pogonomys;

/// <summary>
/// Species: Pogonomys sp. LMB-2011
/// NCBI TaxId: 1078250
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pogonomys_sp_LMB_2011 : Pogonomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pogonomys sp. LMB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pogonomys_sp_LMB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1078250;
}
