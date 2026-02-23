using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labeobarbus.unclassified_Labeobarbus;

/// <summary>
/// Abstract class for unclassified Labeobarbus (no rank).
/// NCBI TaxId: 2626955
/// </summary>
public abstract class unclassified_Labeobarbus : Labeobarbus, Iunclassified_Labeobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labeobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2626955;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labeobarbus";
}
