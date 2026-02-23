namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Lophonetta;

/// <summary>
/// Species: Lophonetta specularioides
/// NCBI TaxId: 75873
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Lophonetta_specularioides : Lophonetta
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Lophonetta specularioides";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Lophonetta_specularioides";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 75873;
}
