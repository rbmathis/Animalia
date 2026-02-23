using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.unclassified_Antennariidae;

/// <summary>
/// Abstract class for unclassified Antennariidae (no rank).
/// NCBI TaxId: 722542
/// </summary>
public abstract class unclassified_Antennariidae : Antennariidae, Iunclassified_Antennariidae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Antennariidae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 722542;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Antennariidae";
}
