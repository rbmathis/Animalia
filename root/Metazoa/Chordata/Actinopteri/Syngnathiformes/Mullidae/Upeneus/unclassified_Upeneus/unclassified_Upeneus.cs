using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Upeneus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Syngnathiformes.Mullidae.Upeneus.unclassified_Upeneus;

/// <summary>
/// Abstract class for unclassified Upeneus (no rank).
/// NCBI TaxId: 2629774
/// </summary>
public abstract class unclassified_Upeneus : Upeneus, Iunclassified_Upeneus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Upeneus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2629774;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Upeneus";
}
