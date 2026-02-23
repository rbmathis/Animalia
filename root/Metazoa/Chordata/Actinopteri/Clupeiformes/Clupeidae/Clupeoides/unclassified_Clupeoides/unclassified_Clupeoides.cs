using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupeoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.Clupeoides.unclassified_Clupeoides;

/// <summary>
/// Abstract class for unclassified Clupeoides (no rank).
/// NCBI TaxId: 2644611
/// </summary>
public abstract class unclassified_Clupeoides : Clupeoides, Iunclassified_Clupeoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clupeoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644611;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clupeoides";
}
