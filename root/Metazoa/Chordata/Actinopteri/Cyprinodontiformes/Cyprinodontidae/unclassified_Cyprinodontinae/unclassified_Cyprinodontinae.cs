using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.unclassified_Cyprinodontinae;

/// <summary>
/// Abstract class for unclassified Cyprinodontinae (no rank).
/// NCBI TaxId: 2964764
/// </summary>
public abstract class unclassified_Cyprinodontinae : Cyprinodontidae, Iunclassified_Cyprinodontinae
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprinodontinae";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2964764;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprinodontinae";
}
