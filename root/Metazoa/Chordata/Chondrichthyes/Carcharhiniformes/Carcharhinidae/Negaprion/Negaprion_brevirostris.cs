namespace AnimalKingdom.root.Metazoa.Chordata.Chondrichthyes.Carcharhiniformes.Carcharhinidae.Negaprion;

/// <summary>
/// Species: Negaprion brevirostris
/// NCBI TaxId: 7821
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Negaprion_brevirostris : Negaprion
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Negaprion brevirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Negaprion_brevirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 7821;
}
