namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae.mouserat_hybrid_cell_lines;

/// <summary>
/// Species: F-11 rat/mouse fusion cell line
/// NCBI TaxId: 266798
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class F_11_ratmouse_fusion_cell_line : mouserat_hybrid_cell_lines
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "F-11 rat/mouse fusion cell line";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "F_11_ratmouse_fusion_cell_line";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 266798;
}
