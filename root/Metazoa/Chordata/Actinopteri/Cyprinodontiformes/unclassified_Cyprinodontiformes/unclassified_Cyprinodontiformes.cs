using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.unclassified_Cyprinodontiformes;

/// <summary>
/// Abstract class for unclassified Cyprinodontiformes (no rank).
/// NCBI TaxId: 725925
/// </summary>
public abstract class unclassified_Cyprinodontiformes : Cyprinodontiformes, Iunclassified_Cyprinodontiformes
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprinodontiformes";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 725925;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprinodontiformes";
}
