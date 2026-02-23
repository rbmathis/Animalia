namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus dalianensis
/// NCBI TaxId: 2848121
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_dalianensis : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus dalianensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_dalianensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2848121;
}
