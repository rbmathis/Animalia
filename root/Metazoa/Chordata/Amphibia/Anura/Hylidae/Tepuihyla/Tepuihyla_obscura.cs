namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Hylidae.Tepuihyla;

/// <summary>
/// Species: Tepuihyla obscura
/// NCBI TaxId: 1224196
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Tepuihyla_obscura : Tepuihyla
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Tepuihyla obscura";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Tepuihyla_obscura";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1224196;
}
