namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Kobus;

/// <summary>
/// Species: Kobus sp.
/// NCBI TaxId: 3056450
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kobus_sp : Kobus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kobus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kobus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3056450;
}
