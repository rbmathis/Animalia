namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Thrichomys;

/// <summary>
/// Species: Thrichomys laurenteus
/// NCBI TaxId: 190470
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thrichomys_laurenteus : Thrichomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thrichomys laurenteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thrichomys_laurenteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 190470;
}
