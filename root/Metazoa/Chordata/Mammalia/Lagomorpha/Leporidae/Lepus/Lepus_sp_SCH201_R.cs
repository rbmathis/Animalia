namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus sp. SCH201_R
/// NCBI TaxId: 2666269
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_sp_SCH201_R : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus sp. SCH201_R";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_sp_SCH201_R";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2666269;
}
