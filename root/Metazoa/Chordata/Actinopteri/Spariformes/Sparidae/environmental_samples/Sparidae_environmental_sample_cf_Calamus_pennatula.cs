namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Sparidae.environmental_samples;

/// <summary>
/// Species: Sparidae environmental sample cf. Calamus pennatula
/// NCBI TaxId: 2592850
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sparidae_environmental_sample_cf_Calamus_pennatula : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sparidae environmental sample cf. Calamus pennatula";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sparidae_environmental_sample_cf_Calamus_pennatula";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2592850;
}
