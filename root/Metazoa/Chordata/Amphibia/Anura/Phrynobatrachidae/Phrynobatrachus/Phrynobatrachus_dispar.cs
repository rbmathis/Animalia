namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

/// <summary>
/// Species: Phrynobatrachus dispar
/// NCBI TaxId: 356238
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynobatrachus_dispar : Phrynobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynobatrachus dispar";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynobatrachus_dispar";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 356238;
}
