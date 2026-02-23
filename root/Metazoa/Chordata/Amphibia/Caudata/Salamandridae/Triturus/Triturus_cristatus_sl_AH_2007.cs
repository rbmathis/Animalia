namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Caudata.Salamandridae.Triturus;

/// <summary>
/// Species: Triturus cristatus s.l. AH-2007
/// NCBI TaxId: 475397
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Triturus_cristatus_sl_AH_2007 : Triturus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Triturus cristatus s.l. AH-2007";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Triturus_cristatus_sl_AH_2007";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 475397;
}
