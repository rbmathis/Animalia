namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Pholidota.Manidae.Manis;

/// <summary>
/// Species: Manis sp. LCT-2010
/// NCBI TaxId: 858577
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Manis_sp_LCT_2010 : Manis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Manis sp. LCT-2010";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Manis_sp_LCT_2010";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 858577;
}
