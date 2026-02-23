namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Cingulata.Dasypodidae.Dasypus;

/// <summary>
/// Species: Dasypus beniensis
/// NCBI TaxId: 2586749
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasypus_beniensis : Dasypus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasypus beniensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasypus_beniensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2586749;
}
