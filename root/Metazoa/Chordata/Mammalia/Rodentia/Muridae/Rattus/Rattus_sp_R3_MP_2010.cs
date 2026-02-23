namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rattus;

/// <summary>
/// Species: Rattus sp. R3 MP-2010
/// NCBI TaxId: 858504
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rattus_sp_R3_MP_2010 : Rattus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rattus sp. R3 MP-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rattus_sp_R3_MP_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 858504;
}
