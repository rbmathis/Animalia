using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Floridichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Cyprinodontidae.Floridichthys.unclassified_Floridichthys;

/// <summary>
/// Abstract class for unclassified Floridichthys (no rank).
/// NCBI TaxId: 2624860
/// </summary>
public abstract class unclassified_Floridichthys : Floridichthys, Iunclassified_Floridichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Floridichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2624860;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Floridichthys";
}
