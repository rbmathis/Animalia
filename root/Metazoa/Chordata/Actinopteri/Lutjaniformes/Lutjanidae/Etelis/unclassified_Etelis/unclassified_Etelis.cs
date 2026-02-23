using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Etelis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Etelis.unclassified_Etelis;

/// <summary>
/// Abstract class for unclassified Etelis (no rank).
/// NCBI TaxId: 2609514
/// </summary>
public abstract class unclassified_Etelis : Etelis, Iunclassified_Etelis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Etelis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2609514;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Etelis";
}
