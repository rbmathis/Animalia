namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.unclassified_Anura;

/// <summary>
/// Species: Anura sp. BOLD:AAK8798
/// NCBI TaxId: 815491
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anura_sp_BOLDAAK8798 : unclassified_Anura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anura sp. BOLD:AAK8798";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anura_sp_BOLDAAK8798";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 815491;
}
