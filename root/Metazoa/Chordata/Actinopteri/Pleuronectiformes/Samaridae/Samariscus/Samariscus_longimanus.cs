namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Pleuronectiformes.Samaridae.Samariscus;

/// <summary>
/// Species: Samariscus longimanus
/// NCBI TaxId: 1585620
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Samariscus_longimanus : Samariscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Samariscus longimanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Samariscus_longimanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1585620;
}
