using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Siluriformes.Loricariidae.unclassified_Loricariidae;

/// <summary>
/// Abstract class for unclassified Loricariidae (no rank).
/// NCBI TaxId: 1532131
/// </summary>
public abstract class unclassified_Loricariidae : Loricariidae, Iunclassified_Loricariidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Loricariidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 1532131;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Loricariidae";
}
