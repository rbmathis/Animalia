namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Species: Dasypus hybridus
/// NCBI TaxId: 1756220
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasypus_hybridus : Dasypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasypus hybridus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasypus_hybridus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1756220;
}
