namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Mesocricetus;

/// <summary>
/// Species: Mesocricetus raddei
/// NCBI TaxId: 329621
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Mesocricetus_raddei : Mesocricetus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Mesocricetus raddei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Mesocricetus_raddei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 329621;
}
