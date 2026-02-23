using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudolabrus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Labriformes.Labridae.Pseudolabrus.unclassified_Pseudolabrus;

/// <summary>
/// Abstract class for unclassified Pseudolabrus (no rank).
/// NCBI TaxId: 2648529
/// </summary>
public abstract class unclassified_Pseudolabrus : Pseudolabrus, Iunclassified_Pseudolabrus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pseudolabrus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2648529;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pseudolabrus";
}
