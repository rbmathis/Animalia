namespace AnimalKingdom.root.Metazoa.Chordata.Aves.environmental_samples;

/// <summary>
/// Species: birdstrike environmental sample
/// NCBI TaxId: 1126252
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class birdstrike_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "birdstrike environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "birdstrike_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1126252;
}
