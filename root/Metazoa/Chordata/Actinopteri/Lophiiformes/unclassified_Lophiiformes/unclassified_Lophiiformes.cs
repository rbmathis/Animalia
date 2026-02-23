using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Lophiiformes.unclassified_Lophiiformes;

/// <summary>
/// Abstract class for unclassified Lophiiformes (no rank).
/// NCBI TaxId: 727485
/// </summary>
public abstract class unclassified_Lophiiformes : Lophiiformes, Iunclassified_Lophiiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Lophiiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 727485;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Lophiiformes";
}
