namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Pachytriton;

/// <summary>
/// Species: Pachytriton airobranchiatus
/// NCBI TaxId: 2135270
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachytriton_airobranchiatus : Pachytriton
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachytriton airobranchiatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachytriton_airobranchiatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2135270;
}
