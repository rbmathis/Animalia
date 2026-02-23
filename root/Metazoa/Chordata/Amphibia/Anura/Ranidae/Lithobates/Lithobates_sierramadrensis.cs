namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Ranidae.Lithobates;

/// <summary>
/// Species: Lithobates sierramadrensis
/// NCBI TaxId: 299664
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lithobates_sierramadrensis : Lithobates
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lithobates sierramadrensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lithobates_sierramadrensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 299664;
}
