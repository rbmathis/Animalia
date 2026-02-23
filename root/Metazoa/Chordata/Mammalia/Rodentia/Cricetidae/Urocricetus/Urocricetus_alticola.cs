namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Urocricetus;

/// <summary>
/// Species: Urocricetus alticola
/// NCBI TaxId: 3122389
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Urocricetus_alticola : Urocricetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Urocricetus alticola";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Urocricetus_alticola";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 3122389;
}
