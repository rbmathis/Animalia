namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Scincidae.Panaspis;

/// <summary>
/// Species: Panaspis cf. breviceps
/// NCBI TaxId: 245654
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Panaspis_cf_breviceps : Panaspis
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Panaspis cf. breviceps";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Panaspis_cf_breviceps";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 245654;
}
