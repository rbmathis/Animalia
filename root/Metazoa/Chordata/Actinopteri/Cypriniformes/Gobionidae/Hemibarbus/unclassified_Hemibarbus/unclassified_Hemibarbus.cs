using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Hemibarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gobionidae.Hemibarbus.unclassified_Hemibarbus;

/// <summary>
/// Abstract class for unclassified Hemibarbus (no rank).
/// NCBI TaxId: 2635321
/// </summary>
public abstract class unclassified_Hemibarbus : Hemibarbus, Iunclassified_Hemibarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hemibarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2635321;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hemibarbus";
}
