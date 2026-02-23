namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus sp. CMN MgVo-3-85-60
/// NCBI TaxId: 330591
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_sp_CMN_MgVo_3_85_60 : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus sp. CMN MgVo-3-85-60";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_sp_CMN_MgVo_3_85_60";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 330591;
}
