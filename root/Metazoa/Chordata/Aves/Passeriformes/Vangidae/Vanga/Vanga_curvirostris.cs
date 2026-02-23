namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Vangidae.Vanga;

/// <summary>
/// Species: Vanga curvirostris
/// NCBI TaxId: 125301
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Vanga_curvirostris : Vanga
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Vanga curvirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Vanga_curvirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 125301;
}
