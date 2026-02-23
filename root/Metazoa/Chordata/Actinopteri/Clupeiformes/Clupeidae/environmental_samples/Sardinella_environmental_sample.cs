namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.environmental_samples;

/// <summary>
/// Species: Sardinella environmental sample
/// NCBI TaxId: 1276580
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sardinella_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sardinella environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sardinella_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1276580;
}
