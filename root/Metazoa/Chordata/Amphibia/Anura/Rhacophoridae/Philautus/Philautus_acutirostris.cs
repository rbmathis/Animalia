namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Rhacophoridae.Philautus;

/// <summary>
/// Species: Philautus acutirostris
/// NCBI TaxId: 191202
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Philautus_acutirostris : Philautus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Philautus acutirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Philautus_acutirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 191202;
}
