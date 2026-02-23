namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Suidae.Phacochoerus;

/// <summary>
/// Species: Phacochoerus aethiopicus
/// NCBI TaxId: 85517
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phacochoerus_aethiopicus : Phacochoerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phacochoerus aethiopicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phacochoerus_aethiopicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 85517;
}
