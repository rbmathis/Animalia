namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Gerbilliscus;

/// <summary>
/// Species: Gerbilliscus sp. ADSB-2016a
/// NCBI TaxId: 1825906
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Gerbilliscus_sp_ADSB_2016a : Gerbilliscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Gerbilliscus sp. ADSB-2016a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Gerbilliscus_sp_ADSB_2016a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1825906;
}
