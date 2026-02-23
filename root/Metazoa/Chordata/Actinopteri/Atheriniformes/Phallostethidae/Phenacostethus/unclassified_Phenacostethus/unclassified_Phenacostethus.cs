using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae.Phenacostethus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Atheriniformes.Phallostethidae.Phenacostethus.unclassified_Phenacostethus;

/// <summary>
/// Abstract class for unclassified Phenacostethus (no rank).
/// NCBI TaxId: 2685278
/// </summary>
public abstract class unclassified_Phenacostethus : Phenacostethus, Iunclassified_Phenacostethus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Phenacostethus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685278;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Phenacostethus";
}
