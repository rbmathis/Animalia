using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Patagonotothen;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Nototheniidae.Patagonotothen.unclassified_Patagonotothen;

/// <summary>
/// Abstract class for unclassified Patagonotothen (no rank).
/// NCBI TaxId: 2676811
/// </summary>
public abstract class unclassified_Patagonotothen : Patagonotothen, Iunclassified_Patagonotothen
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Patagonotothen";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2676811;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Patagonotothen";
}
