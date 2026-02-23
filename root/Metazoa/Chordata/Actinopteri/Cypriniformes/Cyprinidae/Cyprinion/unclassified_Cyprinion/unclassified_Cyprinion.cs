using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Cyprinidae.Cyprinion.unclassified_Cyprinion;

/// <summary>
/// Abstract class for unclassified Cyprinion (no rank).
/// NCBI TaxId: 2640878
/// </summary>
public abstract class unclassified_Cyprinion : Cyprinion, Iunclassified_Cyprinion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprinion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2640878;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprinion";
}
