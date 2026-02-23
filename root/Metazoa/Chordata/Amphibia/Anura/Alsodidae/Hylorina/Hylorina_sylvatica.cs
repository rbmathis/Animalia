namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Alsodidae.Hylorina;

/// <summary>
/// Species: Hylorina sylvatica
/// NCBI TaxId: 247968
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hylorina_sylvatica : Hylorina
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hylorina sylvatica";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hylorina_sylvatica";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 247968;
}
