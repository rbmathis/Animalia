namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Oecomys;

/// <summary>
/// Species: Oecomys sp. AVB-2011
/// NCBI TaxId: 1002704
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oecomys_sp_AVB_2011 : Oecomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oecomys sp. AVB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oecomys_sp_AVB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002704;
}
