using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hypselobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Hypselobarbus.unclassified_Hypselobarbus;

/// <summary>
/// Abstract class for unclassified Hypselobarbus (no rank).
/// NCBI TaxId: 2631032
/// </summary>
public abstract class unclassified_Hypselobarbus : Hypselobarbus, Iunclassified_Hypselobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypselobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631032;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypselobarbus";
}
