namespace AnimalKingdom.root.Metazoa.Chordata.Aves.Nyctibiiformes.Nyctibiidae.Nyctibius;

/// <summary>
/// Species: Nyctibius bracteatus
/// NCBI TaxId: 48426
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibius_bracteatus : Nyctibius
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibius bracteatus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibius_bracteatus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48426;
}
