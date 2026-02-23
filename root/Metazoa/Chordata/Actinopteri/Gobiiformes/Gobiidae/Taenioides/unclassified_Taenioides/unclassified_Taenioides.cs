using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Taenioides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Taenioides.unclassified_Taenioides;

/// <summary>
/// Abstract class for unclassified Taenioides (no rank).
/// NCBI TaxId: 2627574
/// </summary>
public abstract class unclassified_Taenioides : Taenioides, Iunclassified_Taenioides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Taenioides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2627574;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Taenioides";
}
