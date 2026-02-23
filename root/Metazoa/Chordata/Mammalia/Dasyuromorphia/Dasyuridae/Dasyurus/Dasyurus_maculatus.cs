namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Dasyurus;

/// <summary>
/// Species: Dasyurus maculatus
/// NCBI TaxId: 9281
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyurus_maculatus : Dasyurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyurus maculatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyurus_maculatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 9281;
}
