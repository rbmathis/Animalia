namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.unclassified_Primates;

/// <summary>
/// Species: Primates sp. BOLD:AAC7735
/// NCBI TaxId: 1068292
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Primates_sp_BOLDAAC7735 : unclassified_Primates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Primates sp. BOLD:AAC7735";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Primates_sp_BOLDAAC7735";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1068292;
}
