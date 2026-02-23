using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Rhodeus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Acheilognathidae.Rhodeus.unclassified_Rhodeus;

/// <summary>
/// Abstract class for unclassified Rhodeus (no rank).
/// NCBI TaxId: 2649429
/// </summary>
public abstract class unclassified_Rhodeus : Rhodeus, Iunclassified_Rhodeus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Rhodeus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2649429;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Rhodeus";
}
