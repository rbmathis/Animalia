namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Spatula;

/// <summary>
/// Species: Spatula versicolor
/// NCBI TaxId: 75863
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Spatula_versicolor : Spatula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Spatula versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Spatula_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75863;
}
