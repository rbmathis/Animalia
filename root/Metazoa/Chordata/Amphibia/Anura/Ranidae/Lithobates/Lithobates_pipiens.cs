namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates;

/// <summary>
/// Species: Lithobates pipiens
/// NCBI TaxId: 8404
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lithobates_pipiens : Lithobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lithobates pipiens";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lithobates_pipiens";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8404;
}
