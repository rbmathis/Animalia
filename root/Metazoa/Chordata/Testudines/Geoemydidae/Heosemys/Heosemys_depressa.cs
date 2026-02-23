namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Geoemydidae.Heosemys;

/// <summary>
/// Species: Heosemys depressa
/// NCBI TaxId: 260628
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Heosemys_depressa : Heosemys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Heosemys depressa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Heosemys_depressa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 260628;
}
