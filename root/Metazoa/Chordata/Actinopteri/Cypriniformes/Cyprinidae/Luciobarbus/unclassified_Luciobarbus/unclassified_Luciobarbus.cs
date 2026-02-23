using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Luciobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Luciobarbus.unclassified_Luciobarbus;

/// <summary>
/// Abstract class for unclassified Luciobarbus (no rank).
/// NCBI TaxId: 2621432
/// </summary>
public abstract class unclassified_Luciobarbus : Luciobarbus, Iunclassified_Luciobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Luciobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2621432;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Luciobarbus";
}
