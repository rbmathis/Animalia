namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Eupercaria_incertae_sedis.Sciaenidae.environmental_samples;

/// <summary>
/// Species: Menticirrhus environmental sample
/// NCBI TaxId: 1276575
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Menticirrhus_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Menticirrhus environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Menticirrhus_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1276575;
}
