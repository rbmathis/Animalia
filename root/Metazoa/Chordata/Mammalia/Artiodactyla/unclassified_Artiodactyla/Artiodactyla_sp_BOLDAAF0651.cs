namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.unclassified_Artiodactyla;

/// <summary>
/// Species: Artiodactyla sp. BOLD:AAF0651
/// NCBI TaxId: 1068516
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artiodactyla_sp_BOLDAAF0651 : unclassified_Artiodactyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artiodactyla sp. BOLD:AAF0651";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artiodactyla_sp_BOLDAAF0651";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1068516;
}
