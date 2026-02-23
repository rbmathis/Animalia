namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Trinomys;

/// <summary>
/// Species: Trinomys setosus
/// NCBI TaxId: 43323
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Trinomys_setosus : Trinomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Trinomys setosus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Trinomys_setosus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 43323;
}
