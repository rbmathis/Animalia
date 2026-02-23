namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Psammomys;

/// <summary>
/// Species: Psammomys vexillaris
/// NCBI TaxId: 323362
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psammomys_vexillaris : Psammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psammomys vexillaris";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psammomys_vexillaris";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 323362;
}
