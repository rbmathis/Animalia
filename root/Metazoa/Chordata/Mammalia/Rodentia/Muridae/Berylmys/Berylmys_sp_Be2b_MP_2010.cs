namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Berylmys;

/// <summary>
/// Species: Berylmys sp. Be2b MP-2010
/// NCBI TaxId: 857471
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Berylmys_sp_Be2b_MP_2010 : Berylmys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Berylmys sp. Be2b MP-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Berylmys_sp_Be2b_MP_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 857471;
}
