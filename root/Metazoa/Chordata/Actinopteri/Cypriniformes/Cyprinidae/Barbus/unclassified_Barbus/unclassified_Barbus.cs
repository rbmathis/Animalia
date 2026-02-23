using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Barbus.unclassified_Barbus;

/// <summary>
/// Abstract class for unclassified Barbus (no rank).
/// NCBI TaxId: 2631779
/// </summary>
public abstract class unclassified_Barbus : Barbus, Iunclassified_Barbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Barbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2631779;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Barbus";
}
