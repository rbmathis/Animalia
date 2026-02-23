using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptocentroides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Gobiiformes.Gobiidae.Cryptocentroides.unclassified_Cryptocentroides;

/// <summary>
/// Abstract class for unclassified Cryptocentroides (no rank).
/// NCBI TaxId: 2621128
/// </summary>
public abstract class unclassified_Cryptocentroides : Cryptocentroides, Iunclassified_Cryptocentroides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cryptocentroides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621128;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cryptocentroides";
}
