namespace AnimalKingdom.root.Metazoa.Chordata.Amphibia.Anura.Nyctibatrachidae.Nyctibatrachus;

/// <summary>
/// Species: Nyctibatrachus minimus
/// NCBI TaxId: 430794
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctibatrachus_minimus : Nyctibatrachus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctibatrachus minimus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctibatrachus_minimus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 430794;
}
