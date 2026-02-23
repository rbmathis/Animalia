namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Parvoscincus;

/// <summary>
/// Species: Parvoscincus aurorus
/// NCBI TaxId: 1434757
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parvoscincus_aurorus : Parvoscincus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parvoscincus aurorus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parvoscincus_aurorus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1434757;
}
