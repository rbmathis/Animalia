namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Indicatoridae.Indicator;

/// <summary>
/// Species: Indicator sp. GGS-2011
/// NCBI TaxId: 1002903
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Indicator_sp_GGS_2011 : Indicator
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Indicator sp. GGS-2011";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Indicator_sp_GGS_2011";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1002903;
}
