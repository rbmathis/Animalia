namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Thallomys;

/// <summary>
/// Species: Thallomys sp. VN-2012
/// NCBI TaxId: 1261107
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thallomys_sp_VN_2012 : Thallomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thallomys sp. VN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thallomys_sp_VN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1261107;
}
