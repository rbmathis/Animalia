using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pamphorichthys;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cyprinodontiformes.Poeciliidae.Pamphorichthys.unclassified_Pamphorichthys;

/// <summary>
/// Abstract class for unclassified Pamphorichthys (no rank).
/// NCBI TaxId: 2639672
/// </summary>
public abstract class unclassified_Pamphorichthys : Pamphorichthys, Iunclassified_Pamphorichthys
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Pamphorichthys";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 2639672;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Pamphorichthys";
}
