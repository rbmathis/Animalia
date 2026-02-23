namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus sp. ABTC 8540
/// NCBI TaxId: 435485
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_sp_ABTC_8540 : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus sp. ABTC 8540";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_sp_ABTC_8540";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 435485;
}
