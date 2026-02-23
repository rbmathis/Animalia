using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Epiplatys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Nothobranchiidae.Epiplatys.unclassified_Epiplatys;

/// <summary>
/// Abstract class for unclassified Epiplatys (no rank).
/// NCBI TaxId: 2646874
/// </summary>
public abstract class unclassified_Epiplatys : Epiplatys, Iunclassified_Epiplatys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Epiplatys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2646874;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Epiplatys";
}
