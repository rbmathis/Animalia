using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.unclassified_Acrossocheilinae;

/// <summary>
/// Abstract class for unclassified Acrossocheilinae (no rank).
/// NCBI TaxId: 3383493
/// </summary>
public abstract class unclassified_Acrossocheilinae : Cyprinidae, Iunclassified_Acrossocheilinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Acrossocheilinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3383493;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Acrossocheilinae";
}
