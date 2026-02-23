using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Brachyrhamdia;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Heptapteridae.Brachyrhamdia.unclassified_Brachyrhamdia;

/// <summary>
/// Abstract class for unclassified Brachyrhamdia (no rank).
/// NCBI TaxId: 2635941
/// </summary>
public abstract class unclassified_Brachyrhamdia : Brachyrhamdia, Iunclassified_Brachyrhamdia
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Brachyrhamdia";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635941;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Brachyrhamdia";
}
