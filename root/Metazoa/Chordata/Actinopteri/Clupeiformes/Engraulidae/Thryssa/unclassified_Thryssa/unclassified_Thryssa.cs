using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Thryssa;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Clupeiformes.Engraulidae.Thryssa.unclassified_Thryssa;

/// <summary>
/// Abstract class for unclassified Thryssa (no rank).
/// NCBI TaxId: 2619810
/// </summary>
public abstract class unclassified_Thryssa : Thryssa, Iunclassified_Thryssa
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Thryssa";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2619810;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Thryssa";
}
