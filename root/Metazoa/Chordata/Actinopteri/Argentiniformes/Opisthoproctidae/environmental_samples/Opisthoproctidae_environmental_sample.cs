namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Argentiniformes.Opisthoproctidae.environmental_samples;

/// <summary>
/// Species: Opisthoproctidae environmental sample
/// NCBI TaxId: 1986582
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Opisthoproctidae_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Opisthoproctidae environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Opisthoproctidae_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1986582;
}
