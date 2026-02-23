using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Jenkinsia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Jenkinsia.unclassified_Jenkinsia;

/// <summary>
/// Abstract class for unclassified Jenkinsia (no rank).
/// NCBI TaxId: 2634465
/// </summary>
public abstract class unclassified_Jenkinsia : Jenkinsia, Iunclassified_Jenkinsia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Jenkinsia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2634465;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Jenkinsia";
}
