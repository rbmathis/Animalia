using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Pristipomoides;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lutjaniformes.Lutjanidae.Pristipomoides.unclassified_Pristipomoides;

/// <summary>
/// Abstract class for unclassified Pristipomoides (no rank).
/// NCBI TaxId: 2684954
/// </summary>
public abstract class unclassified_Pristipomoides : Pristipomoides, Iunclassified_Pristipomoides
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pristipomoides";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2684954;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pristipomoides";
}
