namespace AnimalKingdom.root.Metazoa.Chordata.Testudines.Kinosternidae.Sternotherus;

/// <summary>
/// Species: Sternotherus depressus
/// NCBI TaxId: 904226
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sternotherus_depressus : Sternotherus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sternotherus depressus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sternotherus_depressus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 904226;
}
