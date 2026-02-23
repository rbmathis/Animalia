namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Gymnophiona.Ichthyophiidae.Ichthyophis;

/// <summary>
/// Species: Ichthyophis bannanicus
/// NCBI TaxId: 8453
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Ichthyophis_bannanicus : Ichthyophis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Ichthyophis bannanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Ichthyophis_bannanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8453;
}
