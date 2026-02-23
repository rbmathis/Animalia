namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Baiomys;

/// <summary>
/// Species: Baiomys musculus
/// NCBI TaxId: 213557
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Baiomys_musculus : Baiomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Baiomys musculus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Baiomys_musculus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 213557;
}
