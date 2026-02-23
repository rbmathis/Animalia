namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Serranidae.environmental_samples;

/// <summary>
/// Species: Epinephelini environmental sample
/// NCBI TaxId: 2002789
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Epinephelini_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Epinephelini environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Epinephelini_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2002789;
}
