namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys;

/// <summary>
/// Species: Phyllomys sp. 2 ACL-2016
/// NCBI TaxId: 1929042
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllomys_sp_2_ACL_2016 : Phyllomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllomys sp. 2 ACL-2016";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllomys_sp_2_ACL_2016";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1929042;
}
