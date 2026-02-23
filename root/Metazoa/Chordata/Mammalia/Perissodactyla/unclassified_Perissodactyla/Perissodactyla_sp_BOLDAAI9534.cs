namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.unclassified_Perissodactyla;

/// <summary>
/// Species: Perissodactyla sp. BOLD:AAI9534
/// NCBI TaxId: 1068253
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perissodactyla_sp_BOLDAAI9534 : unclassified_Perissodactyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perissodactyla sp. BOLD:AAI9534";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perissodactyla_sp_BOLDAAI9534";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1068253;
}
