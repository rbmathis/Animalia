namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

/// <summary>
/// Species: Sternotherus sp.
/// NCBI TaxId: 1980985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sternotherus_sp : Sternotherus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sternotherus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sternotherus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1980985;
}
