using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Clupeidae.unclassified_Pellonulinae;

/// <summary>
/// Abstract class for unclassified Pellonulinae (no rank).
/// NCBI TaxId: 2998577
/// </summary>
public abstract class unclassified_Pellonulinae : Clupeidae, Iunclassified_Pellonulinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pellonulinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2998577;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pellonulinae";
}
