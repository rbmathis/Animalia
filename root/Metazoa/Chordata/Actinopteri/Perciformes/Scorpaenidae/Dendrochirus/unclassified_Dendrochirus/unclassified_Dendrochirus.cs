using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Dendrochirus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Perciformes.Scorpaenidae.Dendrochirus.unclassified_Dendrochirus;

/// <summary>
/// Abstract class for unclassified Dendrochirus (no rank).
/// NCBI TaxId: 2648077
/// </summary>
public abstract class unclassified_Dendrochirus : Dendrochirus, Iunclassified_Dendrochirus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Dendrochirus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648077;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Dendrochirus";
}
