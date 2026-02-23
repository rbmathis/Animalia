using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinus;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinus.unclassified_Cyprinus;

/// <summary>
/// Abstract class for unclassified Cyprinus (no rank).
/// NCBI TaxId: 2685120
/// </summary>
public abstract class unclassified_Cyprinus : Cyprinus, Iunclassified_Cyprinus
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprinus";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2685120;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprinus";
}
