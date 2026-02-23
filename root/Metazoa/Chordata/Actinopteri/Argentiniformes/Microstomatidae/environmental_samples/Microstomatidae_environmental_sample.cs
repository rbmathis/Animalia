namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Microstomatidae.environmental_samples;

/// <summary>
/// Species: Microstomatidae environmental sample
/// NCBI TaxId: 1986579
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Microstomatidae_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Microstomatidae environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Microstomatidae_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986579;
}
