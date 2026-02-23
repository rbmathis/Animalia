namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Physalaemus;

/// <summary>
/// Species: Physalaemus sp.
/// NCBI TaxId: 3063552
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Physalaemus_sp : Physalaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Physalaemus sp.";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Physalaemus_sp";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3063552;
}
