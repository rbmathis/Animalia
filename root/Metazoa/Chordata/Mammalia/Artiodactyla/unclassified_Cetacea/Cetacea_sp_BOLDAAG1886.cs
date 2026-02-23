namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.unclassified_Cetacea;

/// <summary>
/// Species: Cetacea sp. BOLD:AAG1886
/// NCBI TaxId: 816560
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cetacea_sp_BOLDAAG1886 : unclassified_Cetacea
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cetacea sp. BOLD:AAG1886";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cetacea_sp_BOLDAAG1886";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 816560;
}
