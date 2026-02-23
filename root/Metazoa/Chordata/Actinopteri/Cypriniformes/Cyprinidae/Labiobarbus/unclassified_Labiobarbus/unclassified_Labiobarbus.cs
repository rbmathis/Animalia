using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labiobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Labiobarbus.unclassified_Labiobarbus;

/// <summary>
/// Abstract class for unclassified Labiobarbus (no rank).
/// NCBI TaxId: 2647494
/// </summary>
public abstract class unclassified_Labiobarbus : Labiobarbus, Iunclassified_Labiobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labiobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2647494;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labiobarbus";
}
