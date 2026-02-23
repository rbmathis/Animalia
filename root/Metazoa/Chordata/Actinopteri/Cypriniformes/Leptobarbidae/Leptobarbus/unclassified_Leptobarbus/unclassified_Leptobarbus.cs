using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leptobarbidae.Leptobarbus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Leptobarbidae.Leptobarbus.unclassified_Leptobarbus;

/// <summary>
/// Abstract class for unclassified Leptobarbus (no rank).
/// NCBI TaxId: 2622141
/// </summary>
public abstract class unclassified_Leptobarbus : Leptobarbus, Iunclassified_Leptobarbus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Leptobarbus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2622141;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Leptobarbus";
}
