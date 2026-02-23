namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

/// <summary>
/// Species: Sternotherus odoratus
/// NCBI TaxId: 142480
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sternotherus_odoratus : Sternotherus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sternotherus odoratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sternotherus_odoratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 142480;
}
