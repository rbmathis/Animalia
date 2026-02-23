namespace AnimalKingdom.root.Metazoa.Chordata.Lepidosauria.Squamata.Xenodermatidae.Xenodermus;

/// <summary>
/// Species: Xenodermus javanicus
/// NCBI TaxId: 46278
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class Xenodermus_javanicus : Xenodermus
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "Xenodermus javanicus";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "Xenodermus_javanicus";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 46278;
}
