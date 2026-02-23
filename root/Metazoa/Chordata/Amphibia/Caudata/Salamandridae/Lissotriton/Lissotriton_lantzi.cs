namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Lissotriton;

/// <summary>
/// Species: Lissotriton lantzi
/// NCBI TaxId: 3372079
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lissotriton_lantzi : Lissotriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lissotriton lantzi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lissotriton_lantzi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3372079;
}
