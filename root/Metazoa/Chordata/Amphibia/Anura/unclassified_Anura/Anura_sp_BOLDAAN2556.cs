namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Species: Anura sp. BOLD:AAN2556
/// NCBI TaxId: 973846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anura_sp_BOLDAAN2556 : unclassified_Anura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anura sp. BOLD:AAN2556";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anura_sp_BOLDAAN2556";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 973846;
}
