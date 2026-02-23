namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

/// <summary>
/// Species: Sternotherus minor
/// NCBI TaxId: 37593
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sternotherus_minor : Sternotherus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sternotherus minor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sternotherus_minor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 37593;
}
