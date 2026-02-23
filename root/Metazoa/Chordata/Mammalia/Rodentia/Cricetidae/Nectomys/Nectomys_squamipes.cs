namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nectomys;

/// <summary>
/// Species: Nectomys squamipes
/// NCBI TaxId: 29117
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nectomys_squamipes : Nectomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nectomys squamipes";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nectomys_squamipes";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 29117;
}
