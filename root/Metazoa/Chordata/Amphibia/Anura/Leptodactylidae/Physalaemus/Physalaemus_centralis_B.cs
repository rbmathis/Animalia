namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Physalaemus;

/// <summary>
/// Species: Physalaemus centralis B
/// NCBI TaxId: 1097580
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Physalaemus_centralis_B : Physalaemus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Physalaemus centralis B";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Physalaemus_centralis_B";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1097580;
}
