using AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Liniparhomaloptera;

namespace AnimalKingdom.root.Metazoa.Chordata.Actinopteri.Cypriniformes.Gastromyzontidae.Liniparhomaloptera.unclassified_Liniparhomaloptera;

/// <summary>
/// Abstract class for unclassified Liniparhomaloptera (no rank).
/// NCBI TaxId: 3125949
/// </summary>
public abstract class unclassified_Liniparhomaloptera : Liniparhomaloptera, Iunclassified_Liniparhomaloptera
{
    /// <summary>Gets the scientific name.</summary>
    public override string ScientificName => "unclassified Liniparhomaloptera";

    /// <summary>Gets the taxonomic rank.</summary>
    public override string TaxonomicRank => "no rank";

    /// <summary>Gets the NCBI Taxonomy ID.</summary>
    public override int TaxId => 3125949;

    /// <inheritdoc />
    public virtual string Description => "Taxon: unclassified_Liniparhomaloptera";
}
