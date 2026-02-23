namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Phrynobatrachidae.Phrynobatrachus;

/// <summary>
/// Species: Phrynobatrachus sp.
/// NCBI TaxId: 3414034
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phrynobatrachus_sp : Phrynobatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phrynobatrachus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phrynobatrachus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3414034;
}
