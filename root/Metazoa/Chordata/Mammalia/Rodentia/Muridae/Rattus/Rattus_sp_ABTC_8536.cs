namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus sp. ABTC 8536
/// NCBI TaxId: 435484
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_sp_ABTC_8536 : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus sp. ABTC 8536";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_sp_ABTC_8536";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 435484;
}
