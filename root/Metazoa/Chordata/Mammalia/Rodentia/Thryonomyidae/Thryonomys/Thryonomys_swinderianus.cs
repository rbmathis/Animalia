namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Thryonomyidae.Thryonomys;

/// <summary>
/// Species: Thryonomys swinderianus
/// NCBI TaxId: 10169
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thryonomys_swinderianus : Thryonomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thryonomys swinderianus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thryonomys_swinderianus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 10169;
}
