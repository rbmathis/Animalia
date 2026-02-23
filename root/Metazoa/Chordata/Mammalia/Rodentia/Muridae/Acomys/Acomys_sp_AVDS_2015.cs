namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Acomys;

/// <summary>
/// Species: Acomys sp. AVDS-2015
/// NCBI TaxId: 1706393
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Acomys_sp_AVDS_2015 : Acomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Acomys sp. AVDS-2015";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Acomys_sp_AVDS_2015";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1706393;
}
