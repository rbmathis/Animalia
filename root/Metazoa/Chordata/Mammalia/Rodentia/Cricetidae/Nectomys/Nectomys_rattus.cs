namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Cricetidae.Nectomys;

/// <summary>
/// Species: Nectomys rattus
/// NCBI TaxId: 1932377
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Nectomys_rattus : Nectomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Nectomys rattus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Nectomys_rattus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1932377;
}
