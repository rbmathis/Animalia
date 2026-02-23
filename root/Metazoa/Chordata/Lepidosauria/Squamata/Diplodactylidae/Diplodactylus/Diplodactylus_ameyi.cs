namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Diplodactylidae.Diplodactylus;

/// <summary>
/// Species: Diplodactylus ameyi
/// NCBI TaxId: 3055809
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Diplodactylus_ameyi : Diplodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Diplodactylus ameyi";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Diplodactylus_ameyi";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3055809;
}
