using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.unclassified_Cyprinidae;

/// <summary>
/// Abstract class for unclassified Cyprinidae (no rank).
/// NCBI TaxId: 183508
/// </summary>
public abstract class unclassified_Cyprinidae : Cyprinidae, Iunclassified_Cyprinidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprinidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 183508;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprinidae";
}
