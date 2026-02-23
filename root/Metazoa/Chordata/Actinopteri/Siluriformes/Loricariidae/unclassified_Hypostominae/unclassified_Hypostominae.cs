using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Hypostominae;

/// <summary>
/// Abstract class for unclassified Hypostominae (no rank).
/// NCBI TaxId: 1809249
/// </summary>
public abstract class unclassified_Hypostominae : Loricariidae, Iunclassified_Hypostominae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Hypostominae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1809249;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Hypostominae";
}
