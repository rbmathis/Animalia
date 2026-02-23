namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Cynops;

/// <summary>
/// Species: Cynops pyrrhogaster
/// NCBI TaxId: 8330
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cynops_pyrrhogaster : Cynops
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cynops pyrrhogaster";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cynops_pyrrhogaster";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8330;
}
