namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae.mouserat_hybrid_cell_lines;

/// <summary>
/// Species: mouse/rat NG108-15
/// NCBI TaxId: 129386
/// Enrichment Status: Stub (pending enrichment)
/// </summary>
public class mouserat_NG108_15 : mouserat_hybrid_cell_lines
{
    /// <summary>Indicates whether this species has been enriched with full data.</summary>
    public const bool IsEnriched = false;

    /// <summary>Gets the species name.</summary>
    public string SpeciesName => "mouse/rat NG108-15";

    /// <summary>Gets the common name. TODO: Enrich</summary>
    public string CommonName => "mouserat_NG108_15";

    /// <inheritdoc />
    public override string TaxonomicRank => "species";

    /// <inheritdoc />
    public override int TaxId => 129386;
}
