namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Tapiridae.Tapirus;

/// <summary>
/// Species: Tapirus terrestris
/// NCBI TaxId: 9801
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tapirus_terrestris : Tapirus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tapirus terrestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tapirus_terrestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9801;
}
