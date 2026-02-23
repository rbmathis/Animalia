namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

/// <summary>
/// Species: Phyllodactylus tuberculosus
/// NCBI TaxId: 502500
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodactylus_tuberculosus : Phyllodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodactylus tuberculosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodactylus_tuberculosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 502500;
}
