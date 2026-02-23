namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Rhinocerotidae.Diceros;

/// <summary>
/// Species: Diceros bicornis
/// NCBI TaxId: 9805
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diceros_bicornis : Diceros
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diceros bicornis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diceros_bicornis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9805;
}
