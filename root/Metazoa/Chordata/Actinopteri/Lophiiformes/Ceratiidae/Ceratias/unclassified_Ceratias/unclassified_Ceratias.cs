using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.Ceratias;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Ceratiidae.Ceratias.unclassified_Ceratias;

/// <summary>
/// Abstract class for unclassified Ceratias (no rank).
/// NCBI TaxId: 2633694
/// </summary>
public abstract class unclassified_Ceratias : Ceratias, Iunclassified_Ceratias
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Ceratias";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633694;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Ceratias";
}
