namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Reithrodontomys;

/// <summary>
/// Species: Reithrodontomys mexicanus
/// NCBI TaxId: 89150
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Reithrodontomys_mexicanus : Reithrodontomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Reithrodontomys mexicanus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Reithrodontomys_mexicanus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 89150;
}
