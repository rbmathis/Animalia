using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Callopanchax;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Callopanchax.unclassified_Callopanchax;

/// <summary>
/// Abstract class for unclassified Callopanchax (no rank).
/// NCBI TaxId: 2624981
/// </summary>
public abstract class unclassified_Callopanchax : Callopanchax, Iunclassified_Callopanchax
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Callopanchax";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624981;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Callopanchax";
}
