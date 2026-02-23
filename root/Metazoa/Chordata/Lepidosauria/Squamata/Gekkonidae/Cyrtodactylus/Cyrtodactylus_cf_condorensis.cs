namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

/// <summary>
/// Species: Cyrtodactylus cf. condorensis
/// NCBI TaxId: 1234022
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyrtodactylus_cf_condorensis : Cyrtodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyrtodactylus cf. condorensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyrtodactylus_cf_condorensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234022;
}
