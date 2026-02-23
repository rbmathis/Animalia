namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Species: Dasypus sp. VJL-2004
/// NCBI TaxId: 286599
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasypus_sp_VJL_2004 : Dasypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasypus sp. VJL-2004";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasypus_sp_VJL_2004";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286599;
}
