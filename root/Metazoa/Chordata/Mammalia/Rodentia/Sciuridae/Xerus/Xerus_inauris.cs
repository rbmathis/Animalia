namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Sciuridae.Xerus;

/// <summary>
/// Species: Xerus inauris
/// NCBI TaxId: 234690
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xerus_inauris : Xerus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xerus inauris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xerus_inauris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 234690;
}
