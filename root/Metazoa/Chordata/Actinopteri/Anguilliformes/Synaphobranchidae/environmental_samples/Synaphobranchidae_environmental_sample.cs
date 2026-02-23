namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Anguilliformes.Synaphobranchidae.environmental_samples;

/// <summary>
/// Species: Synaphobranchidae environmental sample
/// NCBI TaxId: 1366077
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Synaphobranchidae_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Synaphobranchidae environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Synaphobranchidae_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1366077;
}
