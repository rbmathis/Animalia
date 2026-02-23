namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Praomys;

/// <summary>
/// Species: Praomys sp. A VN-2012
/// NCBI TaxId: 1158283
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Praomys_sp_A_VN_2012 : Praomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Praomys sp. A VN-2012";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Praomys_sp_A_VN_2012";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1158283;
}
