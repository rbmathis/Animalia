namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Diplodactylus;

/// <summary>
/// Species: Diplodactylus vittatus
/// NCBI TaxId: 95112
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diplodactylus_vittatus : Diplodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diplodactylus vittatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diplodactylus_vittatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95112;
}
