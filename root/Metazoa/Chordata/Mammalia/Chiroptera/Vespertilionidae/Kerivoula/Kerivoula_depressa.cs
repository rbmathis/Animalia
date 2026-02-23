namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Chiroptera.Vespertilionidae.Kerivoula;

/// <summary>
/// Species: Kerivoula depressa
/// NCBI TaxId: 2918677
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Kerivoula_depressa : Kerivoula
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Kerivoula depressa";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Kerivoula_depressa";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 2918677;
}
