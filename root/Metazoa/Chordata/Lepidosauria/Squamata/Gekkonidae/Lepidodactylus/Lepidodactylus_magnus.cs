namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Gekkonidae.Lepidodactylus;

/// <summary>
/// Species: Lepidodactylus magnus
/// NCBI TaxId: 2079386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lepidodactylus_magnus : Lepidodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lepidodactylus magnus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lepidodactylus_magnus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2079386;
}
