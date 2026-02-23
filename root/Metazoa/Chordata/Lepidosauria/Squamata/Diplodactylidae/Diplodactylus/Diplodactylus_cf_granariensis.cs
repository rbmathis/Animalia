namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Diplodactylus;

/// <summary>
/// Species: Diplodactylus cf. granariensis
/// NCBI TaxId: 633871
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diplodactylus_cf_granariensis : Diplodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diplodactylus cf. granariensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diplodactylus_cf_granariensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 633871;
}
