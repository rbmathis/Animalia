namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Dasyproctidae.Myoprocta;

/// <summary>
/// Species: Myoprocta sp. AVB-2011
/// NCBI TaxId: 1002700
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myoprocta_sp_AVB_2011 : Myoprocta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myoprocta sp. AVB-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myoprocta_sp_AVB_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002700;
}
