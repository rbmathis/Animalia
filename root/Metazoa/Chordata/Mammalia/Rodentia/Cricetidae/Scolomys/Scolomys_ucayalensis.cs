namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Scolomys;

/// <summary>
/// Species: Scolomys ucayalensis
/// NCBI TaxId: 211798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Scolomys_ucayalensis : Scolomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Scolomys ucayalensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Scolomys_ucayalensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 211798;
}
