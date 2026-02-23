namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.environmental_samples;

/// <summary>
/// Species: bat environmental sample
/// NCBI TaxId: 1617258
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class bat_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "bat environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "bat_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1617258;
}
