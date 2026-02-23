using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Auchenipterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Auchenipteridae.Auchenipterus.unclassified_Auchenipterus;

/// <summary>
/// Abstract class for unclassified Auchenipterus (no rank).
/// NCBI TaxId: 3101814
/// </summary>
public abstract class unclassified_Auchenipterus : Auchenipterus, Iunclassified_Auchenipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Auchenipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101814;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Auchenipterus";
}
