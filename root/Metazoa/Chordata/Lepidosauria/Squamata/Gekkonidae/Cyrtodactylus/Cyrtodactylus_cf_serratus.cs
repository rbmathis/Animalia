namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Cyrtodactylus;

/// <summary>
/// Species: Cyrtodactylus cf. serratus
/// NCBI TaxId: 1234410
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Cyrtodactylus_cf_serratus : Cyrtodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Cyrtodactylus cf. serratus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Cyrtodactylus_cf_serratus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234410;
}
