namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

/// <summary>
/// Species: Phrynobatrachus minutus
/// NCBI TaxId: 467733
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynobatrachus_minutus : Phrynobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynobatrachus minutus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynobatrachus_minutus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 467733;
}
