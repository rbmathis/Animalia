namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus mosbachensis
/// NCBI TaxId: 3456174
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_mosbachensis : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus mosbachensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_mosbachensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3456174;
}
