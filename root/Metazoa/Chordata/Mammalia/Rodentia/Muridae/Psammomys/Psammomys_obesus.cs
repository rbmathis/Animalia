namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.Psammomys;

/// <summary>
/// Species: Psammomys obesus
/// NCBI TaxId: 48139
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Psammomys_obesus : Psammomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Psammomys obesus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Psammomys_obesus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 48139;
}
