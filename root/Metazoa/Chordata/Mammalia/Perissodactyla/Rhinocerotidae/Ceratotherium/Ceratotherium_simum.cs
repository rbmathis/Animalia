namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Ceratotherium;

/// <summary>
/// Species: Ceratotherium simum
/// NCBI TaxId: 9807
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ceratotherium_simum : Ceratotherium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ceratotherium simum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ceratotherium_simum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9807;
}
