using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mystriophis;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Mystriophis.unclassified_Mystriophis;

/// <summary>
/// Abstract class for unclassified Mystriophis (no rank).
/// NCBI TaxId: 3080749
/// </summary>
public abstract class unclassified_Mystriophis : Mystriophis, Iunclassified_Mystriophis
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Mystriophis";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3080749;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Mystriophis";
}
