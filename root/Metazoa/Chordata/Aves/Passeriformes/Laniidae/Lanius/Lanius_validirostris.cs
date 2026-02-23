namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Laniidae.Lanius;

/// <summary>
/// Species: Lanius validirostris
/// NCBI TaxId: 1209826
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lanius_validirostris : Lanius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lanius validirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lanius_validirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1209826;
}
