namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

/// <summary>
/// Species: Phrynobatrachus annulatus
/// NCBI TaxId: 536567
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynobatrachus_annulatus : Phrynobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynobatrachus annulatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynobatrachus_annulatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 536567;
}
