namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Species: Pelodiscus sinensis
/// NCBI TaxId: 13735
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodiscus_sinensis : Pelodiscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodiscus sinensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodiscus_sinensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 13735;
}
