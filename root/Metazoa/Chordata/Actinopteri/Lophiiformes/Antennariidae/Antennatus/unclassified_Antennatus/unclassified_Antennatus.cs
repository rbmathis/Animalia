using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Antennatus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Antennatus.unclassified_Antennatus;

/// <summary>
/// Abstract class for unclassified Antennatus (no rank).
/// NCBI TaxId: 2638387
/// </summary>
public abstract class unclassified_Antennatus : Antennatus, Iunclassified_Antennatus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Antennatus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2638387;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Antennatus";
}
