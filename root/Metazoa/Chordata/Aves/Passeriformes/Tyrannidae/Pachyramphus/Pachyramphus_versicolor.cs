namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Tyrannidae.Pachyramphus;

/// <summary>
/// Species: Pachyramphus versicolor
/// NCBI TaxId: 114334
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Pachyramphus_versicolor : Pachyramphus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Pachyramphus versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Pachyramphus_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 114334;
}
