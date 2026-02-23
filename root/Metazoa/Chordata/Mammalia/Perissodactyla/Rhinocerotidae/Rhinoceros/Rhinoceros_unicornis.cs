namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Rhinoceros;

/// <summary>
/// Species: Rhinoceros unicornis
/// NCBI TaxId: 9809
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinoceros_unicornis : Rhinoceros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinoceros unicornis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinoceros_unicornis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9809;
}
