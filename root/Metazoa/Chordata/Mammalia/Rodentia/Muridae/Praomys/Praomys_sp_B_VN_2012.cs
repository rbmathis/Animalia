namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys sp. B VN-2012
/// NCBI TaxId: 1158284
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_sp_B_VN_2012 : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys sp. B VN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_sp_B_VN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1158284;
}
