namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Lemmiscus;

/// <summary>
/// Species: Lemmiscus curtatus
/// NCBI TaxId: 663699
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lemmiscus_curtatus : Lemmiscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lemmiscus curtatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lemmiscus_curtatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 663699;
}
