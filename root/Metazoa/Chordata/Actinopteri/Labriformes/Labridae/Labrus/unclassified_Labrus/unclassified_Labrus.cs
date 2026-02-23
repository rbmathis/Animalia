using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Labrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Labrus.unclassified_Labrus;

/// <summary>
/// Abstract class for unclassified Labrus (no rank).
/// NCBI TaxId: 2905699
/// </summary>
public abstract class unclassified_Labrus : Labrus, Iunclassified_Labrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Labrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2905699;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Labrus";
}
