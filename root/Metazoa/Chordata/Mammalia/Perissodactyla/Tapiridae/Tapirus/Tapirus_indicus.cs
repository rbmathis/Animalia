namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Species: Tapirus indicus
/// NCBI TaxId: 9802
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tapirus_indicus : Tapirus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tapirus indicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tapirus_indicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9802;
}
