namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus;

/// <summary>
/// Species: Sphenomorphus fasciatus
/// NCBI TaxId: 172934
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphenomorphus_fasciatus : Sphenomorphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphenomorphus fasciatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphenomorphus_fasciatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 172934;
}
