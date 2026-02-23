namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Oenanthe;

/// <summary>
/// Species: Oenanthe melanoleuca
/// NCBI TaxId: 2939378
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oenanthe_melanoleuca : Oenanthe
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oenanthe melanoleuca";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oenanthe_melanoleuca";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2939378;
}
