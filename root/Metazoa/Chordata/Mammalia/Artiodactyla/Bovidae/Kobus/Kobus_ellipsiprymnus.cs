namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

/// <summary>
/// Species: Kobus ellipsiprymnus
/// NCBI TaxId: 9962
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kobus_ellipsiprymnus : Kobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kobus ellipsiprymnus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kobus_ellipsiprymnus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9962;
}
