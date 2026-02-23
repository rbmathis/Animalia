namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Anseriformes.Anatidae.Oxyura;

/// <summary>
/// Species: Oxyura jamaicensis
/// NCBI TaxId: 8884
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Oxyura_jamaicensis : Oxyura
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Oxyura jamaicensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Oxyura_jamaicensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 8884;
}
