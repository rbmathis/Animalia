namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Paridae.Sittiparus;

/// <summary>
/// Species: Sittiparus olivaceus
/// NCBI TaxId: 1464148
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Sittiparus_olivaceus : Sittiparus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Sittiparus olivaceus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Sittiparus_olivaceus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1464148;
}
