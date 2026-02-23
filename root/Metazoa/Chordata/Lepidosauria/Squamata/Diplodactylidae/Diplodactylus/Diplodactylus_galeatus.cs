namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Diplodactylus;

/// <summary>
/// Species: Diplodactylus galeatus
/// NCBI TaxId: 439390
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diplodactylus_galeatus : Diplodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diplodactylus galeatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diplodactylus_galeatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 439390;
}
