namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.unclassified_Primates;

/// <summary>
/// Species: Primates sp. BOLD:AAD0215
/// NCBI TaxId: 1068293
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Primates_sp_BOLDAAD0215 : unclassified_Primates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Primates sp. BOLD:AAD0215";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Primates_sp_BOLDAAD0215";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1068293;
}
