using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Trachipterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lampriformes.Trachipteridae.Trachipterus.unclassified_Trachipterus;

/// <summary>
/// Abstract class for unclassified Trachipterus (no rank).
/// NCBI TaxId: 2644179
/// </summary>
public abstract class unclassified_Trachipterus : Trachipterus, Iunclassified_Trachipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Trachipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644179;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Trachipterus";
}
