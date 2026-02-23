namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Hyorhinomys;

/// <summary>
/// Species: Hyorhinomys stuempkei
/// NCBI TaxId: 1638931
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Hyorhinomys_stuempkei : Hyorhinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Hyorhinomys stuempkei";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Hyorhinomys_stuempkei";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1638931;
}
