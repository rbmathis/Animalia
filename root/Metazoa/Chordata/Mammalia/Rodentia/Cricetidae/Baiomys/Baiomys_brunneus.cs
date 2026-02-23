namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Baiomys;

/// <summary>
/// Species: Baiomys brunneus
/// NCBI TaxId: 2859851
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Baiomys_brunneus : Baiomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Baiomys brunneus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Baiomys_brunneus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2859851;
}
