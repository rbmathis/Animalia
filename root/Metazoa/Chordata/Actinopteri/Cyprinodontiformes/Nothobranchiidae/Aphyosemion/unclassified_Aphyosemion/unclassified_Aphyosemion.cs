using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Aphyosemion;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Aphyosemion.unclassified_Aphyosemion;

/// <summary>
/// Abstract class for unclassified Aphyosemion (no rank).
/// NCBI TaxId: 2644073
/// </summary>
public abstract class unclassified_Aphyosemion : Aphyosemion, Iunclassified_Aphyosemion
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Aphyosemion";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2644073;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Aphyosemion";
}
