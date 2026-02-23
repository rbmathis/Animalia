namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

/// <summary>
/// Species: Phyllodactylus leoni
/// NCBI TaxId: 1279369
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodactylus_leoni : Phyllodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodactylus leoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodactylus_leoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1279369;
}
