using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Blenniiformes.unclassified_Gobiesocoidei;

/// <summary>
/// Abstract class for unclassified Gobiesocoidei (no rank).
/// NCBI TaxId: 948958
/// </summary>
public abstract class unclassified_Gobiesocoidei : Blenniiformes, Iunclassified_Gobiesocoidei
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Gobiesocoidei";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 948958;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Gobiesocoidei";
}
