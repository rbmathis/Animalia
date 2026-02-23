namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.unclassified_Elasmobranchii;

/// <summary>
/// Species: Elasmobranchii sp. BOLD:ACF2385
/// NCBI TaxId: 1629653
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Elasmobranchii_sp_BOLDACF2385 : unclassified_Elasmobranchii
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Elasmobranchii sp. BOLD:ACF2385";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Elasmobranchii_sp_BOLDACF2385";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1629653;
}
