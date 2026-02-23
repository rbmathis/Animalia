namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Microtus;

/// <summary>
/// Species: Microtus sp. BOLD:AAX4252
/// NCBI TaxId: 1158973
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microtus_sp_BOLDAAX4252 : Microtus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microtus sp. BOLD:AAX4252";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microtus_sp_BOLDAAX4252";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1158973;
}
