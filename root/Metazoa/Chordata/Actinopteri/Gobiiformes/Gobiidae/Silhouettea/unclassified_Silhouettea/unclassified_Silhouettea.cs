using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Silhouettea;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Silhouettea.unclassified_Silhouettea;

/// <summary>
/// Abstract class for unclassified Silhouettea (no rank).
/// NCBI TaxId: 2618960
/// </summary>
public abstract class unclassified_Silhouettea : Silhouettea, Iunclassified_Silhouettea
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Silhouettea";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2618960;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Silhouettea";
}
