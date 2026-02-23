namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.environmental_samples;

/// <summary>
/// Species: Clupeiformes environmental sample
/// NCBI TaxId: 1623317
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Clupeiformes_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Clupeiformes environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Clupeiformes_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1623317;
}
