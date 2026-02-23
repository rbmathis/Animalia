namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Dasyuromorphia.Dasyuridae.Dasyurus;

/// <summary>
/// Species: Dasyurus albopunctatus
/// NCBI TaxId: 32545
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Dasyurus_albopunctatus : Dasyurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Dasyurus albopunctatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Dasyurus_albopunctatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 32545;
}
