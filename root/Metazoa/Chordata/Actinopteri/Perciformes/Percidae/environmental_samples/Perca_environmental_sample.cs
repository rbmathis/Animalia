namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Percidae.environmental_samples;

/// <summary>
/// Species: Perca environmental sample
/// NCBI TaxId: 2002819
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Perca_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Perca environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Perca_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2002819;
}
