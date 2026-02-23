namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Natalidae.Nyctiellus;

/// <summary>
/// Species: Nyctiellus lepidus
/// NCBI TaxId: 290566
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nyctiellus_lepidus : Nyctiellus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nyctiellus lepidus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nyctiellus_lepidus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 290566;
}
