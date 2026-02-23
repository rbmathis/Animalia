namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Elasmotherium;

/// <summary>
/// Species: Elasmotherium sibiricum
/// NCBI TaxId: 2491732
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elasmotherium_sibiricum : Elasmotherium
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elasmotherium sibiricum";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elasmotherium_sibiricum";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2491732;
}
