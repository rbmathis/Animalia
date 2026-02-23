namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Sphenomorphus;

/// <summary>
/// Species: Sphenomorphus scutatus
/// NCBI TaxId: 999655
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sphenomorphus_scutatus : Sphenomorphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sphenomorphus scutatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sphenomorphus_scutatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 999655;
}
