namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Leptodactylidae.Leptodactylus;

/// <summary>
/// Species: Leptodactylus longirostris
/// NCBI TaxId: 479894
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Leptodactylus_longirostris : Leptodactylus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Leptodactylus longirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Leptodactylus_longirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 479894;
}
