namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus sp. FMNH 145719
/// NCBI TaxId: 3002829
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_sp_FMNH_145719 : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus sp. FMNH 145719";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_sp_FMNH_145719";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3002829;
}
