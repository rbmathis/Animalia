namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Perissodactyla.Equidae.Equus;

/// <summary>
/// Species: Equus przewalskii
/// NCBI TaxId: 9798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Equus_przewalskii : Equus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Equus przewalskii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Equus_przewalskii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9798;
}
