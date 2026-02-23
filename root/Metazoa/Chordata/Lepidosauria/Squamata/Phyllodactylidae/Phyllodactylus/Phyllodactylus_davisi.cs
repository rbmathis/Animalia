namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

/// <summary>
/// Species: Phyllodactylus davisi
/// NCBI TaxId: 611291
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodactylus_davisi : Phyllodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodactylus davisi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodactylus_davisi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 611291;
}
