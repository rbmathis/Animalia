namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Phodopus;

/// <summary>
/// Species: Phodopus sp. 'ex gr sungorus'
/// NCBI TaxId: 2175847
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phodopus_sp_ex_gr_sungorus : Phodopus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phodopus sp. 'ex gr sungorus'";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phodopus_sp_ex_gr_sungorus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2175847;
}
