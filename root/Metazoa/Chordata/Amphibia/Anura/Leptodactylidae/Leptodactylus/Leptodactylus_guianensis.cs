namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

/// <summary>
/// Species: Leptodactylus guianensis
/// NCBI TaxId: 2738332
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptodactylus_guianensis : Leptodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptodactylus guianensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptodactylus_guianensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2738332;
}
