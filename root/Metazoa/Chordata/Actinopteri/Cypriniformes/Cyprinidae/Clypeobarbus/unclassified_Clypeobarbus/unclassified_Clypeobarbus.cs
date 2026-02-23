using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Clypeobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Clypeobarbus.unclassified_Clypeobarbus;

/// <summary>
/// Abstract class for unclassified Clypeobarbus (no rank).
/// NCBI TaxId: 2621305
/// </summary>
public abstract class unclassified_Clypeobarbus : Clypeobarbus, Iunclassified_Clypeobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Clypeobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621305;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Clypeobarbus";
}
