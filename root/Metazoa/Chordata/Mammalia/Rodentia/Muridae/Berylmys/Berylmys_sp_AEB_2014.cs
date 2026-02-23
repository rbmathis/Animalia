namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Species: Berylmys sp. AEB-2014
/// NCBI TaxId: 1494609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Berylmys_sp_AEB_2014 : Berylmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Berylmys sp. AEB-2014";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Berylmys_sp_AEB_2014";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1494609;
}
