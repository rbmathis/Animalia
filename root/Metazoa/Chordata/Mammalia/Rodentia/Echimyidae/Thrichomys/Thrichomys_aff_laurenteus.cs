namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Echimyidae.Thrichomys;

/// <summary>
/// Species: Thrichomys aff. laurenteus
/// NCBI TaxId: 1341609
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Thrichomys_aff_laurenteus : Thrichomys
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Thrichomys aff. laurenteus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Thrichomys_aff_laurenteus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1341609;
}
