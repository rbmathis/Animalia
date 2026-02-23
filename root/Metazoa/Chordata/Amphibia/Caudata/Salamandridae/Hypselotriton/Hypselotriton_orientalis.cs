namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Hypselotriton;

/// <summary>
/// Species: Hypselotriton orientalis
/// NCBI TaxId: 3399148
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hypselotriton_orientalis : Hypselotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hypselotriton orientalis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hypselotriton_orientalis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3399148;
}
