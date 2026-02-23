using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Nemipterus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Spariformes.Nemipteridae.Nemipterus.unclassified_Nemipterus;

/// <summary>
/// Abstract class for unclassified Nemipterus (no rank).
/// NCBI TaxId: 2633391
/// </summary>
public abstract class unclassified_Nemipterus : Nemipterus, Iunclassified_Nemipterus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Nemipterus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2633391;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Nemipterus";
}
