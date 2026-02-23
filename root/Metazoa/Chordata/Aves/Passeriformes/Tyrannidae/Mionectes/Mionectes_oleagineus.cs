namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Mionectes;

/// <summary>
/// Species: Mionectes oleagineus
/// NCBI TaxId: 123379
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mionectes_oleagineus : Mionectes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mionectes oleagineus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mionectes_oleagineus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 123379;
}
