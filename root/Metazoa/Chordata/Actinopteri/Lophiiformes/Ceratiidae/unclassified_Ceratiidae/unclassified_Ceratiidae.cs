using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.unclassified_Ceratiidae;

/// <summary>
/// Abstract class for unclassified Ceratiidae (no rank).
/// NCBI TaxId: 885008
/// </summary>
public abstract class unclassified_Ceratiidae : Ceratiidae, Iunclassified_Ceratiidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ceratiidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 885008;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ceratiidae";
}
