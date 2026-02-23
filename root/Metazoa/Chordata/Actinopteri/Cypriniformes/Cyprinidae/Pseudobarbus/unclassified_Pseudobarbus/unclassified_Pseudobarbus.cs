using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Pseudobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Pseudobarbus.unclassified_Pseudobarbus;

/// <summary>
/// Abstract class for unclassified Pseudobarbus (no rank).
/// NCBI TaxId: 3350116
/// </summary>
public abstract class unclassified_Pseudobarbus : Pseudobarbus, Iunclassified_Pseudobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3350116;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudobarbus";
}
