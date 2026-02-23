namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Artiodactyla.Bovidae.Hemitragus;

/// <summary>
/// Species: Hemitragus sp.
/// NCBI TaxId: 189981
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hemitragus_sp : Hemitragus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hemitragus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hemitragus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 189981;
}
