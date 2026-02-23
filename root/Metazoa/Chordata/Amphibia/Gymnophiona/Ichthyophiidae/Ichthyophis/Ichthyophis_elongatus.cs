namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Ichthyophis;

/// <summary>
/// Species: Ichthyophis elongatus
/// NCBI TaxId: 3104213
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyophis_elongatus : Ichthyophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyophis elongatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyophis_elongatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3104213;
}
