namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Sirenia.unclassified_Sirenia;

/// <summary>
/// Species: Sirenia sp. BOLD:AAH8089
/// NCBI TaxId: 976661
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sirenia_sp_BOLDAAH8089 : unclassified_Sirenia
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sirenia sp. BOLD:AAH8089";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sirenia_sp_BOLDAAH8089";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 976661;
}
