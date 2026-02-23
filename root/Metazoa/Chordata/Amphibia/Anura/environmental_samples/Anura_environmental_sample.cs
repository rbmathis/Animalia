namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.environmental_samples;

/// <summary>
/// Species: Anura environmental sample
/// NCBI TaxId: 1867795
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anura_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anura environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anura_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1867795;
}
