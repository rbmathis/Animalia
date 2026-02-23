namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Chiropodomys;

/// <summary>
/// Species: Chiropodomys gliroides
/// NCBI TaxId: 491874
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Chiropodomys_gliroides : Chiropodomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Chiropodomys gliroides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Chiropodomys_gliroides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 491874;
}
