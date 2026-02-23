namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.environmental_samples;

/// <summary>
/// Species: Pleuronectes environmental sample
/// NCBI TaxId: 2002822
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pleuronectes_environmental_sample : environmental_samples
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pleuronectes environmental sample";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pleuronectes_environmental_sample";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2002822;
}
