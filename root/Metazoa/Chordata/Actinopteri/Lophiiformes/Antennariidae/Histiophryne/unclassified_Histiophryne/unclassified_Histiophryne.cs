using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Histiophryne;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.Antennariidae.Histiophryne.unclassified_Histiophryne;

/// <summary>
/// Abstract class for unclassified Histiophryne (no rank).
/// NCBI TaxId: 2624164
/// </summary>
public abstract class unclassified_Histiophryne : Histiophryne, Iunclassified_Histiophryne
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Histiophryne";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624164;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Histiophryne";
}
