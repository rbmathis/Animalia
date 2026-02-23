namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Physalaemus;

/// <summary>
/// Species: Physalaemus atlanticus
/// NCBI TaxId: 1356041
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Physalaemus_atlanticus : Physalaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Physalaemus atlanticus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Physalaemus_atlanticus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1356041;
}
