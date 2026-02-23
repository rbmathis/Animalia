namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Hypselotriton;

/// <summary>
/// Species: Hypselotriton yunnanensis
/// NCBI TaxId: 3053476
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hypselotriton_yunnanensis : Hypselotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hypselotriton yunnanensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hypselotriton_yunnanensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3053476;
}
