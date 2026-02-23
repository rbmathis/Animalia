namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gadiformes.Macrouridae.environmental_samples;

/// <summary>
/// Species: Macrouridae environmental sample
/// NCBI TaxId: 2596751
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Macrouridae_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Macrouridae environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Macrouridae_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2596751;
}
