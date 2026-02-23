namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Parotomys;

/// <summary>
/// Species: Parotomys sp. RMA-2005
/// NCBI TaxId: 332678
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Parotomys_sp_RMA_2005 : Parotomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Parotomys sp. RMA-2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Parotomys_sp_RMA_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 332678;
}
