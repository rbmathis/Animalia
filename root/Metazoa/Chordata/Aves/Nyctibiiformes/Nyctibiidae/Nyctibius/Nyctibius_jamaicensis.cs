namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae.Nyctibius;

/// <summary>
/// Species: Nyctibius jamaicensis
/// NCBI TaxId: 662870
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibius_jamaicensis : Nyctibius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibius jamaicensis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibius_jamaicensis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 662870;
}
