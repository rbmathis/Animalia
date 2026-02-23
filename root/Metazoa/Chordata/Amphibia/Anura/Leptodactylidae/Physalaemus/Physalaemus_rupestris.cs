namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Physalaemus;

/// <summary>
/// Species: Physalaemus rupestris
/// NCBI TaxId: 1672243
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Physalaemus_rupestris : Physalaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Physalaemus rupestris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Physalaemus_rupestris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1672243;
}
