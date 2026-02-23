namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Stenodactylus;

/// <summary>
/// Species: Stenodactylus slevini
/// NCBI TaxId: 1234220
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Stenodactylus_slevini : Stenodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Stenodactylus slevini";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Stenodactylus_slevini";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1234220;
}
