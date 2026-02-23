namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Tamias;

/// <summary>
/// Species: Tamias quadrimaculatus
/// NCBI TaxId: 123791
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tamias_quadrimaculatus : Tamias
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tamias quadrimaculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tamias_quadrimaculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123791;
}
