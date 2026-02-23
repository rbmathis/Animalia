namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

/// <summary>
/// Species: Phyllodactylus saxatilis
/// NCBI TaxId: 3147223
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodactylus_saxatilis : Phyllodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodactylus saxatilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodactylus_saxatilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3147223;
}
