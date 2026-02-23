namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Phyllodytes;

/// <summary>
/// Species: Phyllodytes brevirostris
/// NCBI TaxId: 2728956
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phyllodytes_brevirostris : Phyllodytes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phyllodytes brevirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phyllodytes_brevirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2728956;
}
