namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Anas;

/// <summary>
/// Species: Anas eatoni
/// NCBI TaxId: 3149378
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Anas_eatoni : Anas
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Anas eatoni";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Anas_eatoni";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3149378;
}
