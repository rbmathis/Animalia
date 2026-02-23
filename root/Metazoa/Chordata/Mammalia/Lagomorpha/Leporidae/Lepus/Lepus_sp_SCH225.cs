namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Lagomorpha.Leporidae.Lepus;

/// <summary>
/// Species: Lepus sp. SCH225
/// NCBI TaxId: 2666280
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepus_sp_SCH225 : Lepus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepus sp. SCH225";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepus_sp_SCH225";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2666280;
}
