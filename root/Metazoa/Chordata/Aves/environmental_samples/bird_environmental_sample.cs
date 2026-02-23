namespace AnimalKingdom.root.Metazoa.Chordata.Aves.environmental_samples;

/// <summary>
/// Species: bird environmental sample
/// NCBI TaxId: 1229511
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class bird_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "bird environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "bird_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1229511;
}
