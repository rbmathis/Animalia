namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Proechimys;

/// <summary>
/// Species: Proechimys sp. AVB-2011
/// NCBI TaxId: 1002708
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Proechimys_sp_AVB_2011 : Proechimys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Proechimys sp. AVB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Proechimys_sp_AVB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002708;
}
