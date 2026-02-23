using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Laimosemion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Rivulidae.Laimosemion.unclassified_Laimosemion;

/// <summary>
/// Abstract class for unclassified Laimosemion (no rank).
/// NCBI TaxId: 2646329
/// </summary>
public abstract class unclassified_Laimosemion : Laimosemion, Iunclassified_Laimosemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Laimosemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646329;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Laimosemion";
}
