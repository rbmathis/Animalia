using AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae;

namespace AnimalKingdom.root.Metazoa.Chordata.Mammalia.Rodentia.Muridae.unclassified_Muridae.mouserat_hybrid_cell_lines;

/// <summary>
/// Abstract class for mouse/rat hybrid cell lines (no rank).
/// NCBI TaxId: 129429
/// </summary>
public abstract class mouserat_hybrid_cell_lines : unclassified_Muridae, Imouserat_hybrid_cell_lines
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "mouse/rat hybrid cell lines";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 129429;

    /// <inheritdoc />
    public virtual string Description => "Taxon: mouserat_hybrid_cell_lines";
}
