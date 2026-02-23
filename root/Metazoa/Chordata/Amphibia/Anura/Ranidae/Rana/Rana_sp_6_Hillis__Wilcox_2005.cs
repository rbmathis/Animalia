namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Rana;

/// <summary>
/// Species: Rana sp. 6 Hillis & Wilcox, 2005
/// NCBI TaxId: 299693
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rana_sp_6_Hillis__Wilcox_2005 : Rana
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rana sp. 6 Hillis & Wilcox, 2005";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rana_sp_6_Hillis__Wilcox_2005";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 299693;
}
