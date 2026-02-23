namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Philautus;

/// <summary>
/// Species: Philautus sp. Kandy
/// NCBI TaxId: 204715
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Philautus_sp_Kandy : Philautus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Philautus sp. Kandy";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Philautus_sp_Kandy";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 204715;
}
