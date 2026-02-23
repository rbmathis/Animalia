namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae.mouserat_hybrid_cell_lines;

/// <summary>
/// Species: mouse-rat synkaryon
/// NCBI TaxId: 1775465
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class mouse_rat_synkaryon : mouserat_hybrid_cell_lines
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "mouse-rat synkaryon";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "mouse_rat_synkaryon";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 1775465;
}
