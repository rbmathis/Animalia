namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.unclassified_Testudines;

/// <summary>
/// Species: Testudines sp. BOLD:AAK3912
/// NCBI TaxId: 854975
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Testudines_sp_BOLDAAK3912 : unclassified_Testudines
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Testudines sp. BOLD:AAK3912";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Testudines_sp_BOLDAAK3912";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 854975;
}
