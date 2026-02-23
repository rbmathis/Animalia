namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Trinomys;

/// <summary>
/// Species: Trinomys sp. EDH33
/// NCBI TaxId: 109340
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trinomys_sp_EDH33 : Trinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trinomys sp. EDH33";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trinomys_sp_EDH33";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 109340;
}
