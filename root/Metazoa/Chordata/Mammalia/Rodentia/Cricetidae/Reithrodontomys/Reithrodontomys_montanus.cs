namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

/// <summary>
/// Species: Reithrodontomys montanus
/// NCBI TaxId: 129431
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Reithrodontomys_montanus : Reithrodontomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Reithrodontomys montanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Reithrodontomys_montanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129431;
}
