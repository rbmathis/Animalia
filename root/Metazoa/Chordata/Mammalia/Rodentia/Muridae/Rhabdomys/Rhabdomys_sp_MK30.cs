namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Rhabdomys;

/// <summary>
/// Species: Rhabdomys sp. MK30
/// NCBI TaxId: 2819597
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Rhabdomys_sp_MK30 : Rhabdomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Rhabdomys sp. MK30";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Rhabdomys_sp_MK30";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2819597;
}
