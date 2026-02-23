namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Primates.unclassified_Primates;

/// <summary>
/// Species: Primates sp. BOLD:AAA0001
/// NCBI TaxId: 976298
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Primates_sp_BOLDAAA0001 : unclassified_Primates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Primates sp. BOLD:AAA0001";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Primates_sp_BOLDAAA0001";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 976298;
}
