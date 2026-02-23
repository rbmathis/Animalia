namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Elopiformes.Elopidae.environmental_samples;

/// <summary>
/// Species: Elops environmental sample
/// NCBI TaxId: 1276572
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elops_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elops environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elops_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1276572;
}
