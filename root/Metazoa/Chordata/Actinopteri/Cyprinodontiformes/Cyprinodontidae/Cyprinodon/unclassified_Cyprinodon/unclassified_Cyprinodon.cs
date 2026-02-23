using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Cyprinodon;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Cyprinodon.unclassified_Cyprinodon;

/// <summary>
/// Abstract class for unclassified Cyprinodon (no rank).
/// NCBI TaxId: 2630923
/// </summary>
public abstract class unclassified_Cyprinodon : Cyprinodon, Iunclassified_Cyprinodon
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Cyprinodon";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2630923;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Cyprinodon";
}
