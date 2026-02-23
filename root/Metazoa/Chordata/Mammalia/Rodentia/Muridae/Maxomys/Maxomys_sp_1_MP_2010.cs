namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Maxomys;

/// <summary>
/// Species: Maxomys sp. 1 MP-2010
/// NCBI TaxId: 857470
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Maxomys_sp_1_MP_2010 : Maxomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Maxomys sp. 1 MP-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Maxomys_sp_1_MP_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 857470;
}
