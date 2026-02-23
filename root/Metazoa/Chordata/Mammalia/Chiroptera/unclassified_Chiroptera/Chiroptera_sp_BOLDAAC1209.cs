namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.unclassified_Chiroptera;

/// <summary>
/// Species: Chiroptera sp. BOLD:AAC1209
/// NCBI TaxId: 816760
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiroptera_sp_BOLDAAC1209 : unclassified_Chiroptera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiroptera sp. BOLD:AAC1209";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiroptera_sp_BOLDAAC1209";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 816760;
}
