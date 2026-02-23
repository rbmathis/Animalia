namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Wilfredomys;

/// <summary>
/// Species: Wilfredomys oenax
/// NCBI TaxId: 1609091
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Wilfredomys_oenax : Wilfredomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Wilfredomys oenax";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Wilfredomys_oenax";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1609091;
}
