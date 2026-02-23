namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Phyllomys;

/// <summary>
/// Species: Phyllomys sp. ACL-2011
/// NCBI TaxId: 983527
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllomys_sp_ACL_2011 : Phyllomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllomys sp. ACL-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllomys_sp_ACL_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 983527;
}
