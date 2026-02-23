namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Mochlus;

/// <summary>
/// Species: Mochlus cf. sundevalli
/// NCBI TaxId: 245642
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mochlus_cf_sundevalli : Mochlus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mochlus cf. sundevalli";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mochlus_cf_sundevalli";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 245642;
}
