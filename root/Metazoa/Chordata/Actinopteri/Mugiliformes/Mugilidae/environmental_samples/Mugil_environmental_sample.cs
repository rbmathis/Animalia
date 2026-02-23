namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Mugiliformes.Mugilidae.environmental_samples;

/// <summary>
/// Species: Mugil environmental sample
/// NCBI TaxId: 1276577
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mugil_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mugil environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mugil_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1276577;
}
