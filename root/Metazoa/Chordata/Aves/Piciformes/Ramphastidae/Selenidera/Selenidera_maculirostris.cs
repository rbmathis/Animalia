namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Selenidera;

/// <summary>
/// Species: Selenidera maculirostris
/// NCBI TaxId: 95724
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Selenidera_maculirostris : Selenidera
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Selenidera maculirostris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Selenidera_maculirostris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 95724;
}
