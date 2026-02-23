namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lygodactylus;

/// <summary>
/// Species: Lygodactylus rex
/// NCBI TaxId: 1428576
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lygodactylus_rex : Lygodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lygodactylus rex";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lygodactylus_rex";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1428576;
}
