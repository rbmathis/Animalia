namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Erethizontidae.Coendou;

/// <summary>
/// Species: Coendou prehensilis
/// NCBI TaxId: 187985
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Coendou_prehensilis : Coendou
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Coendou prehensilis";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Coendou_prehensilis";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 187985;
}
