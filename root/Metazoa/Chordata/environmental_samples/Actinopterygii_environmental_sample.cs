namespace AnimalKingdom.root.Metazoa.Chordata.environmental_samples;

/// <summary>
/// Species: Actinopterygii environmental sample
/// NCBI TaxId: 1184603
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinopterygii_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinopterygii environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinopterygii_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1184603;
}
