namespace AnimalKingdom.root.Metazoa.Chordata.unclassified_Actinopterygii;

/// <summary>
/// Species: Actinopterygii sp. BOLD:ABW8501
/// NCBI TaxId: 1519049
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Actinopterygii_sp_BOLDABW8501 : unclassified_Actinopterygii
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Actinopterygii sp. BOLD:ABW8501";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Actinopterygii_sp_BOLDABW8501";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1519049;
}
