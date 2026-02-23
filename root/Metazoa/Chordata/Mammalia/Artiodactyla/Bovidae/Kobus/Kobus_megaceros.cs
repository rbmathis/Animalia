namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

/// <summary>
/// Species: Kobus megaceros
/// NCBI TaxId: 59532
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kobus_megaceros : Kobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kobus megaceros";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kobus_megaceros";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 59532;
}
