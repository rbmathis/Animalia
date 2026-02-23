namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

/// <summary>
/// Species: Kobus kob
/// NCBI TaxId: 59530
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kobus_kob : Kobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kobus kob";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kobus_kob";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59530;
}
