using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Hoplerythrinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Characiformes.Erythrinidae.Hoplerythrinus.unclassified_Hoplerythrinus;

/// <summary>
/// Abstract class for unclassified Hoplerythrinus (no rank).
/// NCBI TaxId: 3101855
/// </summary>
public abstract class unclassified_Hoplerythrinus : Hoplerythrinus, Iunclassified_Hoplerythrinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hoplerythrinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3101855;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hoplerythrinus";
}
