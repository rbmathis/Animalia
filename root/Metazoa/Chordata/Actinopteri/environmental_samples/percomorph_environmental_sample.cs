namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.environmental_samples;

/// <summary>
/// Species: percomorph environmental sample
/// NCBI TaxId: 286144
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class percomorph_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "percomorph environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "percomorph_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 286144;
}
