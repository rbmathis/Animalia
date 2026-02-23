namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Passeriformes.Muscicapidae.Phoenicurus;

/// <summary>
/// Species: Phoenicurus bicolor
/// NCBI TaxId: 860617
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Phoenicurus_bicolor : Phoenicurus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Phoenicurus bicolor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Phoenicurus_bicolor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 860617;
}
