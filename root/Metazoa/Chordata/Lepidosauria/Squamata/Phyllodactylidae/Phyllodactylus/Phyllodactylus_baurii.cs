namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Phyllodactylidae.Phyllodactylus;

/// <summary>
/// Species: Phyllodactylus baurii
/// NCBI TaxId: 1549498
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodactylus_baurii : Phyllodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodactylus baurii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodactylus_baurii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1549498;
}
