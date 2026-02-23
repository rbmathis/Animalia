namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Trionychidae.Pelodiscus;

/// <summary>
/// Species: Pelodiscus maackii
/// NCBI TaxId: 980080
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pelodiscus_maackii : Pelodiscus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pelodiscus maackii";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pelodiscus_maackii";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 980080;
}
