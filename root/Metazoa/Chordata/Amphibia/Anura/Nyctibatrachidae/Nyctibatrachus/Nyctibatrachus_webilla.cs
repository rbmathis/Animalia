namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Nyctibatrachus;

/// <summary>
/// Species: Nyctibatrachus webilla
/// NCBI TaxId: 1961694
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibatrachus_webilla : Nyctibatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibatrachus webilla";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibatrachus_webilla";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1961694;
}
