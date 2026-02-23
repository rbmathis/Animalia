namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Netta;

/// <summary>
/// Species: Netta rufina
/// NCBI TaxId: 30387
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Netta_rufina : Netta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Netta rufina";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Netta_rufina";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 30387;
}
