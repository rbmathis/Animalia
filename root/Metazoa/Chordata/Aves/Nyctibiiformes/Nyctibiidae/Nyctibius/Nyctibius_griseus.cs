namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae.Nyctibius;

/// <summary>
/// Species: Nyctibius griseus
/// NCBI TaxId: 48428
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibius_griseus : Nyctibius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibius griseus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibius_griseus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48428;
}
