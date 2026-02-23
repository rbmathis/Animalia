namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Beryciformes.Melamphaidae.environmental_samples;

/// <summary>
/// Species: Melamphaidae environmental sample
/// NCBI TaxId: 1986913
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Melamphaidae_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Melamphaidae environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Melamphaidae_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986913;
}
