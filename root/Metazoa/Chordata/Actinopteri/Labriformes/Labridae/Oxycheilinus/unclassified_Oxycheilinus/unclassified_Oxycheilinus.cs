using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Oxycheilinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Oxycheilinus.unclassified_Oxycheilinus;

/// <summary>
/// Abstract class for unclassified Oxycheilinus (no rank).
/// NCBI TaxId: 2664833
/// </summary>
public abstract class unclassified_Oxycheilinus : Oxycheilinus, Iunclassified_Oxycheilinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Oxycheilinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2664833;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Oxycheilinus";
}
