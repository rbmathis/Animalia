namespace AnimalKingdom.root.Metazoa.Chordata.Appendicularia.environmental_samples;

/// <summary>
/// Species: Appendicularia environmental sample
/// NCBI TaxId: 668958
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Appendicularia_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Appendicularia environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Appendicularia_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 668958;
}
