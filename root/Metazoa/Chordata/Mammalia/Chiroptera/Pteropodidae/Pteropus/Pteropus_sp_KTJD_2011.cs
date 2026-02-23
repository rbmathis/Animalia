namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Pteropodidae.Pteropus;

/// <summary>
/// Species: Pteropus sp. KTJD-2011
/// NCBI TaxId: 1129003
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pteropus_sp_KTJD_2011 : Pteropus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pteropus sp. KTJD-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pteropus_sp_KTJD_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1129003;
}
