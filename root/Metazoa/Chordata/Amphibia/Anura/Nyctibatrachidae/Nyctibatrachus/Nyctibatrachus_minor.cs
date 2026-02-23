namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Nyctibatrachus;

/// <summary>
/// Species: Nyctibatrachus minor
/// NCBI TaxId: 430795
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibatrachus_minor : Nyctibatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibatrachus minor";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibatrachus_minor";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 430795;
}
