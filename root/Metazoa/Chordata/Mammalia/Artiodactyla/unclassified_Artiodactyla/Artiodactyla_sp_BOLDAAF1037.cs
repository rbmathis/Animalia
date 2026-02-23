namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.unclassified_Artiodactyla;

/// <summary>
/// Species: Artiodactyla sp. BOLD:AAF1037
/// NCBI TaxId: 948949
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Artiodactyla_sp_BOLDAAF1037 : unclassified_Artiodactyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Artiodactyla sp. BOLD:AAF1037";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Artiodactyla_sp_BOLDAAF1037";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 948949;
}
