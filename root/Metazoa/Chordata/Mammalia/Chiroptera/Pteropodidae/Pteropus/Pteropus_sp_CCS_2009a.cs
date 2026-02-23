namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

/// <summary>
/// Species: Pteropus sp. CCS-2009a
/// NCBI TaxId: 638936
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteropus_sp_CCS_2009a : Pteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteropus sp. CCS-2009a";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteropus_sp_CCS_2009a";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 638936;
}
