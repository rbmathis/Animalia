namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Myodes;

/// <summary>
/// Species: Myodes californicus
/// NCBI TaxId: 913846
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Myodes_californicus : Myodes
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Myodes californicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Myodes_californicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 913846;
}
