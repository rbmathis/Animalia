namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tepuihyla;

/// <summary>
/// Species: Tepuihyla edelcae
/// NCBI TaxId: 318413
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tepuihyla_edelcae : Tepuihyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tepuihyla edelcae";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tepuihyla_edelcae";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 318413;
}
