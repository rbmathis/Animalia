namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

/// <summary>
/// Species: Phrynobatrachus keniensis
/// NCBI TaxId: 467738
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynobatrachus_keniensis : Phrynobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynobatrachus keniensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynobatrachus_keniensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 467738;
}
