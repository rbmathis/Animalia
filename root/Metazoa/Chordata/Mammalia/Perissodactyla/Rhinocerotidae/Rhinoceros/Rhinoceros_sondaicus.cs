namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Rhinoceros;

/// <summary>
/// Species: Rhinoceros sondaicus
/// NCBI TaxId: 102233
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhinoceros_sondaicus : Rhinoceros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhinoceros sondaicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhinoceros_sondaicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 102233;
}
