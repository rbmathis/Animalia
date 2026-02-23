namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Actinopterygii;

/// <summary>
/// Species: Actinopterygii sp. BOLD:ABW8500
/// NCBI TaxId: 1519048
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinopterygii_sp_BOLDABW8500 : unclassified_Actinopterygii
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinopterygii sp. BOLD:ABW8500";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinopterygii_sp_BOLDABW8500";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1519048;
}
