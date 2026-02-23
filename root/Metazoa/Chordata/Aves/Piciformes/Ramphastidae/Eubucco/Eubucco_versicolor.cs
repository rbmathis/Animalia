namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Piciformes.Ramphastidae.Eubucco;

/// <summary>
/// Species: Eubucco versicolor
/// NCBI TaxId: 1426919
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Eubucco_versicolor : Eubucco
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Eubucco versicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Eubucco_versicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1426919;
}
